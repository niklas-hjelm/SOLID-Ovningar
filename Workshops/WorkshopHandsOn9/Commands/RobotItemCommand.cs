using System;

namespace WorkshopHandsOn9.Commands
{
    public abstract class RobotItemCommand : RobotCommand
    {
        protected Func<IRobot, object> ActionToExecute { get; set; }

        public RobotItemCommand(IRobot robot, Func<IRobot, object> func)
            : base(robot) 
        {
            this.ActionToExecute = func;
        }
    }
}
