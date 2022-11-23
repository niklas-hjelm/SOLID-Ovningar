using System;

namespace WorkshopHandsOn10.Exceptions
{
    public class RobotOutOfMemoryException : ApplicationException
    {
        public RobotOutOfMemoryException()
            : base("Robot has no more memory!")
        { }
    }
}
