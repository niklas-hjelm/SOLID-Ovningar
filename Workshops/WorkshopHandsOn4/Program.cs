using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WorkshopHandsOn4.Commands;
using WorkshopHandsOn4.Log_Strategies;
using WorkshopHandsOn4.ExceptionChain;
using WorkshopHandsOn4.Validation;
using WorkshopHandsOn4.ValueObjects;

namespace WorkshopHandsOn4
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogService logger = LogService.Create();
            IExceptionService service = ExceptionService.Create(logger);
            IValidationService<IRobot> validationService = ValidationService<IRobot>.Create().AddValidator(RobotValidator.Create());
            try
            {
                IRobot robot = Robot.Create(validationService, logger);
                ICommandInvoker controller = CommandInvoker.Create();

                robot.SetCanWalkOn()
                     .SetPowerOn();

                ICommand command = new MoveToCommand(robot) { Position = Position.Create(5, 0) };
                controller.AddCommand(command);

                command = new PickUpCommand(robot);
                controller.AddCommand(command);

                command = new MoveToCommand(robot) { Position = Position.Create(0, 0) };
                controller.AddCommand(command);

                command = new ReleaseCommand(robot);
                controller.AddCommand(command);

                controller.ExecuteCommands();
            }
            catch (Exception ex)
            {
                service.Process(ex);
            }
            Console.ReadKey();        
        }
    }
}
