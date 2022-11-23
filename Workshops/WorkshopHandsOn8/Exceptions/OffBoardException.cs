using System;

namespace WorkshopHandsOn8.Exceptions
{
    public class OffBoardException : ApplicationException
    {
        public OffBoardException()
            : base("You are trying to goto a position outside the board!")
        { }
    }
}
