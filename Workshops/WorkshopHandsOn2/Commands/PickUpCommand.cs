using System;

namespace WorkshopHandsOn2.Commands
{
    public class PickUpCommand : RobotCommand
    {
        public PickUpCommand(IRobot robot) : base(robot) {}

        public override void Execute()
        {
            this.Robot.Grab();
        }
    }
}
