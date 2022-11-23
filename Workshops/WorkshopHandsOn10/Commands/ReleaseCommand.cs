using System;
using WorkshopHandsOn10.Exceptions;

namespace WorkshopHandsOn10.Commands
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
