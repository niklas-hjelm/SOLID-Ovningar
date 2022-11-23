using System;
using WorkshopHandsOn9.ValueObjects;

namespace WorkshopHandsOn9.Commands
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
