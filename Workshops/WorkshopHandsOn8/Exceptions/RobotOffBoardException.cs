using System;

namespace WorkshopHandsOn8.Exceptions
{
    public class RobotOffBoardException : ApplicationException
    {
        public RobotOffBoardException()
            : base("Robot is trying to goto a position outside the board!")
        { }
    }
}
