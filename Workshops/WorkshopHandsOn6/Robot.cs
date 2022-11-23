using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using WorkshopHandsOn6.Exceptions;
using WorkshopHandsOn6.Validation;
using WorkshopHandsOn6.Log_Strategies;
using WorkshopHandsOn6.Rules;
using WorkshopHandsOn6.ValueObjects;
using WorkshopHandsOn6.Messages;
using WorkshopHandsOn6.Extensions;

namespace WorkshopHandsOn6
{
    public class Robot : IRobot
    {
        private RobotFlags _flags = RobotFlags.None;
        private IServiceBus _servicebus;
        private IValidationService<IRobot> _validationService;
        private ILogService _logger;
        private Position _position = Position.Create();
        private Guid ID { get; set; }

        public static IRobot Create(IValidationService<IRobot> validationService, ILogService logger, IServiceBus servicebus, string name)
        {
            return new Robot(validationService, logger, servicebus, name);
        }
        private Robot(IValidationService<IRobot> validationService, ILogService logger, IServiceBus servicebus, string name)
        {
            this.Name = name;
            this.ID = Guid.NewGuid();
            this._validationService = validationService;
            this._logger = logger;
            this._servicebus = servicebus;
            this._servicebus.Register<CheckPositionCommand>(e => this.CheckPositionCommandHandler(e));
            this._servicebus.Register<PositionIsTakenEvent>(e => this.PositionIsTakenEventHandler(e));
        }
        private void CheckPositionCommandHandler(CheckPositionCommand e)
        {
            if (!e.IsSender(this.ID))
            {
                this._logger.Log(string.Format("{0}, Receiving message CheckPositionCommand", this.Name));
                this._logger.Log(string.Format("{0}, Sending message PositionIsTakenEvent: My Position {1}", this.Name, this.CurrentPosition().ToString()));
                this._servicebus.Publish<PositionIsTakenEvent>(new PositionIsTakenEvent(e.Data.Equals(this.CurrentPosition()), this.ID));
            }
        }
        private void PositionIsTakenEventHandler(PositionIsTakenEvent e)
        {
            if (!e.IsSender(this.ID))
            {
                this._logger.Log(string.Format("{0}, Receiving message PositionIsTakenEvent: Position Taken {1}", this.Name, e.Data));

                // If Data=false -> position is free
                if (!e.Data) 
                    this.SetCanWalkOn();
                else
                    this.SetCanWalkOff();
            }
        }
        public string Name { get; private set; }
        public void MoveTo(Position position)
        {
            this._servicebus.Publish<CheckPositionCommand>(new CheckPositionCommand(position, this.ID));

            this.CanTakeAction();
            string message = string.Format("{0} moved to Position {1}.", this.Name, position.ToString());
            this._position = Position.Create(position);
            this._logger.Log(message);
            //throw new RobotNotWalkingException();
        }
        public void Release(Func<IRobot, object> func)
        {
            this.CanTakeAction();
            this._logger.Log(func.Invoke(this).ToString());
            // throw new RobotOutOfMemoryException();
        }
        public void Grab(Func<IRobot, object> func)
        {
            this.CanTakeAction();
            this._logger.Log(func.Invoke(this).ToString());
        }
        public Position CurrentPosition()
        {
            return this._position;
        }
        public Tuple<Boolean, IEnumerable<string>> Validate(IValidator<IRobot> validator)
        {
            IEnumerable<string> broken = validator.BrokenRules(this);
            return Tuple.Create(broken.Count() == 0, broken);
        }
        public bool CanWalk()
        {
            return this._flags.HasFlag(RobotFlags.CanWalk);
        }
        public IRobotState SetCanWalkOn()
        {
            this._flags = this._flags.Set(RobotFlags.CanWalk);
            return this;
        }
        public IRobotState SetCanWalkOff()
        {
            this._flags = this._flags.Remove(RobotFlags.CanWalk);
            return this;
        }
        public IRobotState SetPowerOff()
        {
            this._flags = this._flags.Remove(RobotFlags.PowerOn);
            return this;
        }
        public bool IsPowerOn()
        {
            return this._flags.HasFlag(RobotFlags.PowerOn);
        }
        public IRobotState SetPowerOn()
        {
            this._flags = this._flags.Set(RobotFlags.PowerOn);
            return this;
        }
        private void CanTakeAction()
        {
            Tuple<Boolean, IEnumerable<string>> result = this._validationService.Validate((IRobot)this);
            if (!result.Item1)
            {
                string msg = string.Format("{0}, Validation failed: {1}", this.Name, result.Item2.Aggregate((s, b) => s + ", " + b));
                this._logger.Log(msg);
                throw new ApplicationException(msg);
            }
        }
    }
}
