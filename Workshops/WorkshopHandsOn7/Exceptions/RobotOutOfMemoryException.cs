using System;

namespace WorkshopHandsOn7.Exceptions
{
    public class RobotOutOfMemoryException : ApplicationException
    {
        public RobotOutOfMemoryException()
            : base("Robot has no more memory!")
        { }
    }
}
