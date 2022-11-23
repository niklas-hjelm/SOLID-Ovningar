using System;

namespace WorkshopHandsOn9.Exceptions
{
    public class RobotNotWalkingException : ApplicationException
    {
        public RobotNotWalkingException()
            : base("Robot is not walking!")
        { }
    }
}
