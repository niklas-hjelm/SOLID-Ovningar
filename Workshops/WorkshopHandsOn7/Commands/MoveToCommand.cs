using System;
using WorkshopHandsOn7.ValueObjects;

namespace WorkshopHandsOn7.Commands
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
