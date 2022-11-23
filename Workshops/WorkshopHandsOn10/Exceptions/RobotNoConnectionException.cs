using System;

namespace WorkshopHandsOn10.Exceptions
{
    public class RobotNoConnectionException : ApplicationException
    {
        public RobotNoConnectionException()
            : base("No connection to Robot!")
        { }
    }
}
