using System;
namespace WorkshopHandsOn7.ValueObjects
{
    interface IPlayingBoard
    {
        int Area { get; }
        void CheckBoardPosition(Position position);
        Position GetRandomPosition();
        System.Drawing.Size Size { get; }
    }
}
