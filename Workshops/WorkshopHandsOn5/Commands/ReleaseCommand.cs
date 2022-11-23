using System;
using WorkshopHandsOn5.Exceptions;

namespace WorkshopHandsOn5.Commands
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
