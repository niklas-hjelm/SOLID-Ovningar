using System;

namespace WorkshopHandsOn6.Exceptions
{
    public class RobotNoConnectionException : ApplicationException
    {
        public RobotNoConnectionException()
            : base("No connection to Robot!")
        { }
    }
}
