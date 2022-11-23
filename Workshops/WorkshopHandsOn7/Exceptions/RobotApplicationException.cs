using System;

namespace WorkshopHandsOn7.Exceptions
{
    public class RobotApplicationException : ApplicationException
    {
        public RobotApplicationException(string message)
            : base(message)
        { }
    }
}
