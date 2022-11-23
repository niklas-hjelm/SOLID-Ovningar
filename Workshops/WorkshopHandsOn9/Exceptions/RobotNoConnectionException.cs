using System;

namespace WorkshopHandsOn9.Exceptions
{
    public class RobotNoConnectionException : ApplicationException
    {
        public RobotNoConnectionException()
            : base("No connection to Robot!")
        { }
    }
}
