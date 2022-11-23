using System;
using WorkshopHandsOn9.Exceptions;

namespace WorkshopHandsOn9.Commands
{
    public class ReleaseCommand : RobotItemCommand
    {
        public ReleaseCommand(IRobot robot, Func<IRobot, object> func) : base(robot, func) { }

        public override void Execute()
        {
            this.Robot.Release(this.ActionToExecute);
        }
    }
}
