using System;

namespace WorkshopHandsOn9.Exceptions
{
    public class OffBoardException : ApplicationException
    {
        public OffBoardException()
            : base("You are trying to goto a position outside the board!")
        { }
    }
}
