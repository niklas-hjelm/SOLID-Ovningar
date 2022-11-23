using System;
using WorkshopHandsOn5.Commands;
using WorkshopHandsOn5.ValueObjects;

namespace WorkshopHandsOn5.Algorithms
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
            return "Robot grabbed the box.";
        }
        private string ReleasedBox(IRobot robot)
        {
            // throw new RobotOutOfMemoryException();
            return "Robot released down the box.";
        }
    }
}
