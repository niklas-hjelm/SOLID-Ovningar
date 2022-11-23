using System;

namespace WorkshopHandsOn10.Exceptions
{
    public class RobotNotWalkingException : ApplicationException
    {
        public RobotNotWalkingException()
            : base("Robot is not walking!")
        { }
    }
}
