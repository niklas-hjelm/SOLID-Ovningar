using System;

namespace WorkshopHandsOn11.Exceptions
{
    public class RobotNotWalkingException : ApplicationException
    {
        public RobotNotWalkingException()
            : base("Robot is not walking!")
        { }
    }
}
