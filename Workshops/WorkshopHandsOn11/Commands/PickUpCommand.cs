using System;

namespace WorkshopHandsOn11.Commands
{
    public class PickUpCommand : RobotItemCommand
    {
        public PickUpCommand(IRobot robot, Func<IRobot, object> func) : base(robot, func) { }

        public override void Execute()
        {
            this.Robot.Grab(this.ActionToExecute);
        }
    }
}
