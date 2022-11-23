using System;
using WorkshopHandsOn8.Exceptions;

namespace WorkshopHandsOn8.Commands
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
