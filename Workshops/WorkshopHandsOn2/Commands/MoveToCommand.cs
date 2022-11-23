using System;
using WorkshopHandsOn2.ValueObjects;

namespace WorkshopHandsOn2.Commands
{
    public class MoveToCommand : RobotCommand
    {
        public Position Position { get; set; }

        public MoveToCommand(IRobot robot) : base(robot) { }

        public override void Execute()
        {
            this.Robot.MoveTo(this.Position);
        }
    }
}
