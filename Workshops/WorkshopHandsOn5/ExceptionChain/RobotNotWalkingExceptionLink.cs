using System;
using WorkshopHandsOn5.Exceptions;

namespace WorkshopHandsOn5.ExceptionChain
{
    public class RobotNotWalkingExceptionLink : ChainLink
    {
        public RobotNotWalkingExceptionLink(IChainLink successor) 
            : base(successor) 
        { 
        }
        public override void Process(Exception ex)
        {
            if (ex is RobotNotWalkingException)
            {
                Console.WriteLine("Handle by RobotNotWalkingException link");
                return;
            }
            this.Successor.Process(ex);
        }
    }
}
