using System;

namespace WorkshopHandsOn9.Exceptions
{
    public class RobotApplicationException : ApplicationException
    {
        public RobotApplicationException(string message)
            : base(message)
        { }
    }
}
