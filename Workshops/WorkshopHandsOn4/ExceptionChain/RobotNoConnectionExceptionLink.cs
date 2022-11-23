using System;
using WorkshopHandsOn4.Exceptions;

namespace WorkshopHandsOn4.ExceptionChain
{
    public class RobotNoConnectionExceptionLink : ChainLink
    {
        public RobotNoConnectionExceptionLink(IChainLink successor) 
            : base(successor) 
        { 
        }
        public override void Process(Exception ex)
        {
            if (ex is RobotNoConnectionException)
            {
                Console.WriteLine("Handle by RobotNoConnectionException link");
                return;
            }
            this.Successor.Process(ex);
        }
    }
}
