using System;

namespace WorkshopHandsOn6.Exceptions
{
    public class RobotNotWalkingException : ApplicationException
    {
        public RobotNotWalkingException()
            : base("Robot is not walking!")
        { }
    }
}
