using System;

namespace WorkshopHandsOn4.Commands
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
