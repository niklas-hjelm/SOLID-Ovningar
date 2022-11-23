using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using WorkshopHandsOn4.Exceptions;
using WorkshopHandsOn4.Validation;
using WorkshopHandsOn4.Log_Strategies;
using WorkshopHandsOn4.Rules;
using WorkshopHandsOn4.ValueObjects;
using WorkshopHandsOn4.Extensions;

namespace WorkshopHandsOn4
{
    public class Robot : IRobot
    {
        private RobotFlags _flags = RobotFlags.None;
        private IValidationService<IRobot> _validationService;
        private ILogService _logger;
        private Position _position = Position.Create();

        public static IRobot Create(IValidationService<IRobot> validationService, ILogService logger)
        {
            return new Robot(validationService, logger);
        }
        private Robot(IValidationService<IRobot> validationService, ILogService logger)
        {
            this._validationService = validationService;
            this._logger = logger;
        }
        public void MoveTo(Position position)
        {
            this.CanTakeAction();

            //throw new RobotNotWalkingException();

            string message = string.Format("Robot moved to Position({0},{1}).", position.X, position.Y);
            this._position = Position.Create(position);
            this._logger.Log(message);
        }
        public void Release()
        {
            this.CanTakeAction();

            //throw new RobotOutOfMemoryException();
            throw new ArgumentNullException();

            string message = "Robot sat down the box.";
            this._logger.Log(message);
        }
        public void Grab()
        {
            this.CanTakeAction();
            string message = "Robot picked up the box.";
            this._logger.Log(message);
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
                string msg = "Validation failed: " + result.Item2.Aggregate((s, b) => s + ", " + b);
                this._logger.Log(msg);
                throw new ApplicationException(msg);
            }
        }
    }
}
