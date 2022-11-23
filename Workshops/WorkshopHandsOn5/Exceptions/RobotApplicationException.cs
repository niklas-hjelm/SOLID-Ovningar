using System;

namespace WorkshopHandsOn5.Exceptions
{
    public class RobotApplicationException : ApplicationException
    {
        public RobotApplicationException(string message)
            : base(message)
        { }
    }
}
