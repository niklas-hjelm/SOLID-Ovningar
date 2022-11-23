using System;

namespace WorkshopHandsOn2.Commands
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
