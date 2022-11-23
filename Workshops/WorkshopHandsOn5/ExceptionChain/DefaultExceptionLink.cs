using System;
using WorkshopHandsOn5.Exceptions;

namespace WorkshopHandsOn5.ExceptionChain
{
    public class DefaultExceptionLink : ChainLink
    {
        public DefaultExceptionLink()
            : base(null)
        {
        }
        public override void Process(Exception ex)
        {
            Console.WriteLine("DefaultExceptionLink link");
        }
    }
}
