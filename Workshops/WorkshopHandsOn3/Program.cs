using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WorkshopHandsOn3.Commands;
using WorkshopHandsOn3.Log_Strategies;
using WorkshopHandsOn3.Validation;
using WorkshopHandsOn3.ValueObjects;

namespace WorkshopHandsOn3
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogService logger = LogService.Create();
            IValidationService<IRobot> validationService = ValidationService<IRobot>.Create().AddValidator(RobotValidator.Create());

            IRobot robot = Robot.Create(validationService, logger);
            ICommandInvoker controller = CommandInvoker.Create();

           robot.SetPowerOn();

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
