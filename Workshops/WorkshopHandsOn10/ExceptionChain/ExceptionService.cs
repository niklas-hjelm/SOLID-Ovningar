using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WorkshopHandsOn10.Log_Strategies;

namespace WorkshopHandsOn10.ExceptionChain
{
    public class ExceptionService : IExceptionService
    {
        private ILogService _logger;
        private IChainLink _links;

        private ExceptionService(ILogService logger)
        {
            this._logger = logger;
            this.BuildChain();
        }
        public static IExceptionService Create(ILogService logger)
        {
            return new ExceptionService(logger);
        }
        private void BuildChain()
        {
            this._links = new RobotNoConnectionExceptionLink(
                                    new RobotNotWalkingExceptionLink(
                                        new RobotOutOfMemoryExceptionLink(
                                            new DefaultExceptionLink())));

        }
        public void Process(Exception ex)
        {
            this._logger.Log(string.Format("{0}, {1}", ex.GetType().Name, ex.Message));
            this._links.Process(ex);
        }
    }
}
