using System;
using WorkshopHandsOn1.Commands;
using WorkshopHandsOn1.ValueObjects;

namespace WorkshopHandsOn1
{
    class Program
    {
        static void Main(string[] args)
        {
            IRobot robot = Robot.Create();
            ICommandInvoker controller = CommandInvoker.Create();

            ICommand command = new MoveToCommand(robot) { Position = Position.Create(5, 0) };
            controller.AddCommand(command);

            command = new PickUpCommand(robot);
            controller.AddCommand(command);

            command = new MoveToCommand(robot) { Position = Position.Create(0, 0) };
            controller.AddCommand(command);

            command = new ReleaseCommand(robot);
            controller.AddCommand(command);

            controller.ExecuteCommands();

            Console.ReadKey();
        }
    }
}
