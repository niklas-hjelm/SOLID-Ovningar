using System;

namespace WorkshopHandsOn10.Exceptions
{
    public class RobotApplicationException : ApplicationException
    {
        public RobotApplicationException(string message)
            : base(message)
        { }
    }
}
