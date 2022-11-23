using System;
using WorkshopHandsOn8.Commands;
using WorkshopHandsOn8.Log_Strategies;
using WorkshopHandsOn8.ExceptionChain;
using WorkshopHandsOn8.Validation;
using WorkshopHandsOn8.Algorithms;
using WorkshopHandsOn8.Messages;
using WorkshopHandsOn8.Navigation;
using System.Collections.Generic;
using WorkshopHandsOn8.ValueObjects;

namespace WorkshopHandsOn8
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
