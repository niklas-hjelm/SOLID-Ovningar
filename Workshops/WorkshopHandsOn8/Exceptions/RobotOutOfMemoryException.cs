using System;

namespace WorkshopHandsOn8.Exceptions
{
    public class RobotOutOfMemoryException : ApplicationException
    {
        public RobotOutOfMemoryException()
            : base("Robot has no more memory!")
        { }
    }
}
