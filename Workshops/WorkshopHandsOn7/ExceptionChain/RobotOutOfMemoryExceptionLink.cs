using System;
using WorkshopHandsOn7.Exceptions;

namespace WorkshopHandsOn7.ExceptionChain
{
    public class RobotOutOfMemoryExceptionLink : ChainLink
    {
        public RobotOutOfMemoryExceptionLink(IChainLink successor) 
            : base(successor) 
        { 
        }
        public override void Process(Exception ex)
        {
            if (ex is RobotOutOfMemoryException)
            {
                Console.WriteLine("Handle by RobotOutOfMemoryException link");
                return;
            }
            this.Successor.Process(ex);
        }
    }
}
