using System;
using WorkshopHandsOn8.Commands;
using WorkshopHandsOn8.ValueObjects;

namespace WorkshopHandsOn8.Algorithms
{
    public class MoveBoxAlgorithm : IRobotAlgorithm
    {
        public void Execute(IRobot robot)
        {
            robot.SetCanWalkOn()
                 .SetPowerOn();

            ICommandInvoker controller = CommandInvoker.Create();

            ICommand command = new MoveToCommand(robot) { Position = Position.Create(5, 0) };
            controller.AddCommand(command);

            command = new PickUpCommand(robot, r => this.GrabBox(robot));
            controller.AddCommand(command);

            command = new MoveToCommand(robot) { Position = Position.Create(0, 0) };
            controller.AddCommand(command);

            command = new ReleaseCommand(robot, r => this.ReleasedBox(robot));
            controller.AddCommand(command);

            controller.ExecuteCommands();

            robot.SetCanWalkOn()
                 .SetPowerOff();
        }
        private string GrabBox(IRobot robot)
        {
            return string.Format("{0} grabbed the box.", robot.Name);
        }
        private string ReleasedBox(IRobot robot)
        {
            // throw new RobotOutOfMemoryException();
            return string.Format("{0} released the box.", robot.Name); 
        }
    }
}
