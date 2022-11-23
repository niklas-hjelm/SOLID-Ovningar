using System;

namespace WorkshopHandsOn5.Exceptions
{
    public class RobotNoConnectionException : ApplicationException
    {
        public RobotNoConnectionException()
            : base("No connection to Robot!")
        { }
    }
}
