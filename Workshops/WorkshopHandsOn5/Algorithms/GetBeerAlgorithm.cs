using System;
using WorkshopHandsOn5.Commands;
using WorkshopHandsOn5.Exceptions;
using WorkshopHandsOn5.ValueObjects;

namespace WorkshopHandsOn5.Algorithms
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
            return "Robot grabbed the beer.";
        }
        private string ReleasedBeer(IRobot robot)
        {
            // throw new RobotOutOfMemoryException();
            return "Robot released down the beer.";
        }
    }
}
