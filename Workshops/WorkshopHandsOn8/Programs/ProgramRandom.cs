using System;
using System.Collections.Generic;
using WorkshopHandsOn8.Commands;
using WorkshopHandsOn8.Log_Strategies;
using WorkshopHandsOn8.ExceptionChain;
using WorkshopHandsOn8.Validation;
using WorkshopHandsOn8.Algorithms;
using WorkshopHandsOn8.Messages;
using WorkshopHandsOn8.Navigation;
using WorkshopHandsOn8.ValueObjects;

namespace WorkshopHandsOn8
{
    class ProgramRandom
    {
        public static void Execute()
        {
            IPlayingBoard board = PlayingBoard.Create(8, 11);
            IServiceBus servicebus = ServiceBus.Create();
            ILogService logger = LogService.Create();
            IExceptionService service = ExceptionService.Create(logger);
            IValidationService<IRobot> validationService = ValidationService<IRobot>.Create().AddValidator(RobotValidator.Create());
            INavigationService navigationService = NavigationService.Create(servicebus, ParkingLot.Create(), board);
            try
            {
                IList<IRobot> robots = new List<IRobot>();
                for (int i = 1; i <= board.Area; i++)
                {
                    robots.Add(Robot.Create(validationService, logger, servicebus, "Robot" + i, navigationService));
                }
                foreach (IRobot r in robots)
                {
                    r.SetPowerOn();
                    r.ForceMoveTo(navigationService.GetRandomPosition());
                }
                PrintSorted(logger, robots);
                logger.Log("Program Done!");
            }
            catch (Exception ex)
            {
                service.Process(ex);
            }
            Console.ReadKey();
        }
        private static void PrintSorted(ILogService logger, IList<IRobot> robots)
        {
            IDictionary<string, IRobot> sortedRobots = new SortedList<string, IRobot>();
            foreach (IRobot r in robots)
            {
                sortedRobots.Add(r.CurrentPosition().ToString(), r);
            }
            foreach (KeyValuePair<string, IRobot> kv in sortedRobots)
            {
                logger.Log(string.Format("Position {0} has {1}.", kv.Key, kv.Value.Name));
            }
        }
    }
}
