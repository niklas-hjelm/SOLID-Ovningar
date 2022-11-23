using System;
using WorkshopHandsOn4.Exceptions;

namespace WorkshopHandsOn4.ExceptionChain
{
    public class DefaultExceptionLink : ChainLink
    {
        public DefaultExceptionLink()
            : base(null)
        {
        }
        public override void Process(Exception ex)
        {
            Console.WriteLine("Handle by DefaultExceptionLink link");
        }
    }
}
