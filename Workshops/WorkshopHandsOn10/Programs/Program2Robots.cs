using System;
using WorkshopHandsOn10.Commands;
using WorkshopHandsOn10.Log_Strategies;
using WorkshopHandsOn10.ExceptionChain;
using WorkshopHandsOn10.Validation;
using WorkshopHandsOn10.Algorithms;
using WorkshopHandsOn10.Messages;
using WorkshopHandsOn10.Navigation;
using System.Collections.Generic;
using WorkshopHandsOn10.ValueObjects;

namespace WorkshopHandsOn10
{
    class Program2Robots
    {
        public static void Execute()
        {
            IPlayingBoard board = PlayingBoard.Create(8, 8);
            IServiceBus servicebus = ServiceBus.Create();
            ILogService logger = LogService.Create();
            IExceptionService service = ExceptionService.Create(logger);
            IValidationService<IRobot> validationService = ValidationService<IRobot>.Create().AddValidator(RobotValidator.Create());
            INavigationService navigationService = NavigationService.Create(servicebus, ParkingLot.Create(), board);
            try
            {
                IRobot robot1 = Robot.Create(validationService, logger, servicebus, "Robot1", navigationService);
                IRobot robot2 = Robot.Create(validationService, logger, servicebus, "Robot2", navigationService);

                robot1.SetPowerOn();
                robot1.MoveTo(Position.Create(5, 0));

                robot2.SetPowerOn();
                robot2.ForceMoveTo(Position.Create(5, 0));
            }
            catch (Exception ex)
            {
                service.Process(ex);
            }
            Console.ReadKey();
        }
    }
}
