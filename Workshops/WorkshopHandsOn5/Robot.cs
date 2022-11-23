using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using WorkshopHandsOn5.Exceptions;
using WorkshopHandsOn5.Validation;
using WorkshopHandsOn5.Log_Strategies;
using WorkshopHandsOn5.Rules;
using WorkshopHandsOn5.ValueObjects;
using WorkshopHandsOn5.Extensions;

namespace WorkshopHandsOn5
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
            string message = string.Format("Robot moved to Position({0},{1}).", position.X, position.Y);
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
                string msg = "Validation failed: " + result.Item2.Aggregate((s, b) => s + ", " + b);
                this._logger.Log(msg);
                throw new ApplicationException(msg);
            }
        }
    }
}
