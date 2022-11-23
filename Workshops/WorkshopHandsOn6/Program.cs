using System;
using WorkshopHandsOn6.Commands;
using WorkshopHandsOn6.Log_Strategies;
using WorkshopHandsOn6.ExceptionChain;
using WorkshopHandsOn6.Validation;
using WorkshopHandsOn6.Algorithms;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Remoting.Messaging;
using System.Reflection;
using WorkshopHandsOn6.Messages;
using WorkshopHandsOn6.ValueObjects;

namespace WorkshopHandsOn6
{
    class Program
    {
        static void Main(string[] args)
        {
            IServiceBus servicebus = ServiceBus.Create();
            ILogService logger = LogService.Create();
            IExceptionService service = ExceptionService.Create(logger);
            IValidationService<IRobot> validationService = ValidationService<IRobot>.Create().AddValidator(RobotValidator.Create());
            try
            {
                IRobot robot1 = Robot.Create(validationService, logger, servicebus, "IRobot 1");
                IRobot robot2 = Robot.Create(validationService, logger, servicebus, "IRobot 2");

                robot1.SetPowerOn();
                robot1.MoveTo(Position.Create(5, 1));

                robot2.SetPowerOn();
                robot2.MoveTo(Position.Create(5, 1));

                //IAlgorithmService algorithmService = AlgorithmService.Create();
                //algorithmService.Execute(robot);
            }
            catch (Exception ex)
            {
                service.Process(ex);
            }
            Console.ReadKey();
        }
    }
}
