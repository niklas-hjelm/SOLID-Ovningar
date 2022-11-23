using System;

namespace WorkshopHandsOn7.Commands
{
    public abstract class RobotCommand : ICommand
    {
        protected IRobot Robot { get; set; }

        public RobotCommand(IRobot robot)
        {
            this.Robot = robot;
        }
        public abstract void Execute(); 
    }
}
