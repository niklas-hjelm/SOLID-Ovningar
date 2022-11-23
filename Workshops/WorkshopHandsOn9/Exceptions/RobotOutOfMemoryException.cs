using System;

namespace WorkshopHandsOn9.Exceptions
{
    public class RobotOutOfMemoryException : ApplicationException
    {
        public RobotOutOfMemoryException()
            : base("Robot has no more memory!")
        { }
    }
}
