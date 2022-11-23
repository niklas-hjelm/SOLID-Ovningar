using System;

namespace WorkshopHandsOn7.Exceptions
{
    public class RobotNoConnectionException : ApplicationException
    {
        public RobotNoConnectionException()
            : base("No connection to Robot!")
        { }
    }
}
