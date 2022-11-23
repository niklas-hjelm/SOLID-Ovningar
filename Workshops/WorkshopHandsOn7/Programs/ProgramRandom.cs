using System;
using System.Collections.Generic;
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
    class ProgramRandom
    {
        public static void Execute()
        {
            IPlayingBoard board = PlayingBoard.Create(2, 2);
            IServiceBus servicebus = ServiceBus.Create();
            ILogService logger = LogService.Create();
            IExceptionService service = ExceptionService.Create(logger);
            IValidationService<IRobot> validationService = ValidationService<IRobot>.Create().AddValidator(RobotValidator.Create());
            INavigationService navigationService = NavigationService.Create(servicebus, board);
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
                    r.MoveToAnyFreePosition();
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
