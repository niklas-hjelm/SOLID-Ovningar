using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WorkshopHandsOn2.Commands;
using WorkshopHandsOn2.Log_Strategies;
using WorkshopHandsOn2.ValueObjects;

namespace WorkshopHandsOn2
{
    class Program
    {
        static void Main(string[] args)
        {
            IRobot robot = Robot.Create(LogService.Create(LogTypes.Printer));
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
