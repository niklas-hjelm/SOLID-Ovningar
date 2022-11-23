using System;
using WorkshopHandsOn6.Exceptions;

namespace WorkshopHandsOn6.ExceptionChain
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
