using System;

namespace WorkshopHandsOn9.Exceptions
{
    public class RobotOffBoardException : ApplicationException
    {
        public RobotOffBoardException()
            : base("Robot is trying to goto a position outside the board!")
        { }
    }
}
