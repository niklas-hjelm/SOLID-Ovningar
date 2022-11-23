using System;
namespace WorkshopHandsOn8.ValueObjects
{
    interface IPlayingBoard
    {
        int Area { get; }
        void CheckBoardPosition(Position position);
        Position GetRandomPosition();
        System.Drawing.Size Size { get; }
    }
}
