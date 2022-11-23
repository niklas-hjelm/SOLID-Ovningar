using System;

namespace WorkshopHandsOn11.Exceptions
{
    public class RobotApplicationException : ApplicationException
    {
        public RobotApplicationException(string message)
            : base(message)
        { }
    }
}
