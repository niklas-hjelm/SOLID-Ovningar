using System;

namespace WorkshopHandsOn8.Exceptions
{
    public class RobotNotWalkingException : ApplicationException
    {
        public RobotNotWalkingException()
            : base("Robot is not walking!")
        { }
    }
}
