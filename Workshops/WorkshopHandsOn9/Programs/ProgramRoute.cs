using System;
using System.Linq;
using System.Collections.Generic;
using WorkshopHandsOn9.Commands;
using WorkshopHandsOn9.Log_Strategies;
using WorkshopHandsOn9.ExceptionChain;
using WorkshopHandsOn9.Validation;
using WorkshopHandsOn9.Algorithms;
using WorkshopHandsOn9.Messages;
using WorkshopHandsOn9.Navigation;
using WorkshopHandsOn9.ValueObjects;
using WorkshopHandsOn9.Routes;

namespace WorkshopHandsOn9.Programs
{
    class ProgramRoute
    {
        public static void Execute()
        {
            ILogService logger = LogService.Create();
            IRouteService routeService = RouteService.Create();
            IPlayingBoard board = PlayingBoard.Create(8, 8, logger);
            IServiceBus servicebus = ServiceBus.Create();           
            IExceptionService service = ExceptionService.Create(logger);
            IValidationService<IRobot> validationService = ValidationService<IRobot>.Create().AddValidator(RobotValidator.Create());
            INavigationService navigationService = NavigationService.Create(servicebus, ParkingLot.Create(), board, routeService);
            try
            {
                Position startPos = Position.Create(1, 1);
                Position endPos = Position.Create(board.Size.Width, board.Size.Height);
                IList<Position> exclude = new List<Position>() { startPos, endPos };

                IList<IRobot> robots = new List<IRobot>();
                for (int i = 1; i <= (board.Area * 0.40); i++)
                {
                    robots.Add(Robot.Create(validationService, logger, servicebus, "Robot" + i, navigationService));
                }
                foreach (IRobot r in robots)
                {
                    r.SetPowerOn();
                    r.MoveTo(navigationService.GetFreeRandomPosition(exclude));
                }

                PrintSorted(logger, robots);

                IRobot routeRobot = Robot.Create(validationService, logger, servicebus, "RobotX", navigationService);
                IList<Position> route = navigationService.GetRoute(routeRobot.ID, startPos, endPos);
                routeRobot.SetPowerOn().SetCanWalkOn();
                routeRobot.SetCurrentPosition(startPos);
                routeRobot.Move(route);

                board.Print(route);
            
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
