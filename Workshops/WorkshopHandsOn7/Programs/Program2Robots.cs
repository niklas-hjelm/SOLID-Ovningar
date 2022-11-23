using System;
using WorkshopHandsOn7.Commands;
using WorkshopHandsOn7.Log_Strategies;
using WorkshopHandsOn7.ExceptionChain;
using WorkshopHandsOn7.Validation;
using WorkshopHandsOn7.Algorithms;
using WorkshopHandsOn7.Messages;
using WorkshopHandsOn7.Navigation;
using WorkshopHandsOn7.ValueObjects;

namespace WorkshopHandsOn7
{
    class Program2Robots
    {
        public static void Execute()
        {
            IPlayingBoard board = PlayingBoard.Create(2, 3);
            IServiceBus servicebus = ServiceBus.Create();
            ILogService logger = LogService.Create();
            IExceptionService service = ExceptionService.Create(logger);
            IValidationService<IRobot> validationService = ValidationService<IRobot>.Create().AddValidator(RobotValidator.Create());
            INavigationService navigationService = NavigationService.Create(servicebus, board);
            try
            {
                IRobot robot1 = Robot.Create(validationService, logger, servicebus, "Robot1", navigationService);
                IRobot robot2 = Robot.Create(validationService, logger, servicebus, "Robot2", navigationService);
 
                robot1.SetPowerOn();

                robot2.SetPowerOn();
                robot2.MoveTo(Position.Create(1, 2));

                robot1.MoveToAnyFreePosition();         
            }
            catch (Exception ex)
            {
                service.Process(ex);
            }
            Console.ReadKey();
        }
    }
}
