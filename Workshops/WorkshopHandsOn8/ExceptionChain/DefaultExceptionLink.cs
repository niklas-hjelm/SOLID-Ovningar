using System;
using WorkshopHandsOn8.Exceptions;

namespace WorkshopHandsOn8.ExceptionChain
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
