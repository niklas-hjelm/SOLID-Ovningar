using System;

namespace WorkshopHandsOn6.Exceptions
{
    public class RobotOutOfMemoryException : ApplicationException
    {
        public RobotOutOfMemoryException()
            : base("Robot has no more memory!")
        { }
    }
}
