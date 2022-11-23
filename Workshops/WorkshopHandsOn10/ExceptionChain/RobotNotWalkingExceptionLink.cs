using System;
using WorkshopHandsOn10.Exceptions;

namespace WorkshopHandsOn10.ExceptionChain
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
