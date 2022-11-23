using System;
using WorkshopHandsOn11.Exceptions;

namespace WorkshopHandsOn11.ExceptionChain
{
    public class DefaultExceptionLink : ChainLink
    {
        public DefaultExceptionLink()
            : base(null)
        {
        }
        public override void Process(Exception ex)
        {
            string s = string.Format("{0}{1}{2}", ex.Message, Environment.NewLine, ex.StackTrace);
            Console.WriteLine(string.Format("Exception: {0}", s));
        }
    }
}
