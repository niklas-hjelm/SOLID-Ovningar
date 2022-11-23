using System;

namespace WorkshopHandsOn10.Exceptions
{
    public class RobotOffBoardException : ApplicationException
    {
        public RobotOffBoardException()
            : base("Robot is trying to goto a position outside the board!")
        { }
    }
}
