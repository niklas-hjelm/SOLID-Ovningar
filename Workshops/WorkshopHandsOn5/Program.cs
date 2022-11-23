using System;
using WorkshopHandsOn5.Commands;
using WorkshopHandsOn5.Log_Strategies;
using WorkshopHandsOn5.ExceptionChain;
using WorkshopHandsOn5.Validation;
using WorkshopHandsOn5.Algorithms;

namespace WorkshopHandsOn5
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
                IAlgorithmService algorithmService = AlgorithmService.Create();
                algorithmService.Execute(robot);    

                algorithmService.SetAlgorithm(AlgorithmTypes.GetBeer);
                algorithmService.Execute(robot);         
            }
            catch (Exception ex)
            {
                service.Process(ex);
            }
            Console.ReadKey();        
        }
    }
}
