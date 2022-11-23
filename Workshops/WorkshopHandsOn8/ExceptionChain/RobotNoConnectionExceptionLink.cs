using System;
using WorkshopHandsOn8.Exceptions;

namespace WorkshopHandsOn8.ExceptionChain
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
