using System;
using WorkshopHandsOn7.Exceptions;

namespace WorkshopHandsOn7.ExceptionChain
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
