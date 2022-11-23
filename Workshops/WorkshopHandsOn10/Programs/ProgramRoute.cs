using System;
using System.Linq;
using System.Collections.Generic;
using WorkshopHandsOn10.Commands;
using WorkshopHandsOn10.Log_Strategies;
using WorkshopHandsOn10.ExceptionChain;
using WorkshopHandsOn10.Validation;
using WorkshopHandsOn10.Algorithms;
using WorkshopHandsOn10.Messages;
using WorkshopHandsOn10.Navigation;
using WorkshopHandsOn10.ValueObjects;
using WorkshopHandsOn10.Routes;
using WorkshopHandsOn10.MessageHandlers;

namespace WorkshopHandsOn10.Programs
{
    class ProgramRoute
    {
        public static void Execute()
        {
            ILogService logger = LogService.Create();
            IRouteService routeService = RouteService.Create();
            IPlayingBoard board = PlayingBoard.Create(10, 10, logger);
            IServiceBus servicebus = ServiceBus.Create();           
            IExceptionService service = ExceptionService.Create(logger);
            IValidationService<IRobot> validationService = ValidationService<IRobot>.Create().AddValidator(RobotValidator.Create());
            INavigationService navigationService = NavigationService.Create(servicebus, ParkingLot.Create(), board, routeService);
            IMessageHandler<SendSMSCommand> smsHandler = SMSCommandHandler.Create(servicebus, logger);
            IMessageHandler<SendMailCommand> mailHandler = MailCommandHandler.Create(servicebus, logger);
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
