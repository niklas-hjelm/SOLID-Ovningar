using System;

namespace WorkshopHandsOn4.Commands
{
    public class ReleaseCommand : RobotCommand
    {
        public ReleaseCommand(IRobot robot) : base(robot) { }

        public override void Execute()
        {
            this.Robot.Release();
        }
    }
}
