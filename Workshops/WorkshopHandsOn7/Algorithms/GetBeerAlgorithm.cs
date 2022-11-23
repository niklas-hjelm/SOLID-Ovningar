using System;
using WorkshopHandsOn7.Commands;
using WorkshopHandsOn7.ValueObjects;
using WorkshopHandsOn7.Exceptions;

namespace WorkshopHandsOn7.Algorithms
{
    public class GetBeerAlgorithm : IRobotAlgorithm
    {
        public void Execute(IRobot robot)
        {
            robot.SetCanWalkOn()
                 .SetPowerOn();

            ICommandInvoker controller = CommandInvoker.Create();

            ICommand command = new MoveToCommand(robot) { Position = Position.Create(5, 0) };
            controller.AddCommand(command);

            command = new PickUpCommand(robot, r => this.GrabBeer(robot));
            controller.AddCommand(command);

            command = new MoveToCommand(robot) { Position = Position.Create(0, 0) };
            controller.AddCommand(command);

            command = new ReleaseCommand(robot, r => this.ReleasedBeer(robot));
            controller.AddCommand(command);

            controller.ExecuteCommands();

            robot.SetCanWalkOn()
                 .SetPowerOff();
        }
        private string GrabBeer(IRobot robot)
        {
            return string.Format("{0} grabbed the beer.", robot.Name);
        }
        private string ReleasedBeer(IRobot robot)
        {
            // throw new RobotOutOfMemoryException();
            return string.Format("{0} released the beer.", robot.Name); 
        }
    }
}
