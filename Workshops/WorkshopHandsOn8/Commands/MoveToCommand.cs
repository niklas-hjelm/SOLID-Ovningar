using System;
using WorkshopHandsOn8.ValueObjects;

namespace WorkshopHandsOn8.Commands
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
