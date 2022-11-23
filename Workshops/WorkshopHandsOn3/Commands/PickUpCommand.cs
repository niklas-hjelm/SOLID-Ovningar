using System;

namespace WorkshopHandsOn3.Commands
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
