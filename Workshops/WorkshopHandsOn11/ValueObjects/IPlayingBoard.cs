using System;
using System.Drawing;
using System.Collections.Generic;

namespace WorkshopHandsOn11.ValueObjects
{
    public interface IPlayingBoard
    {
        Tile[,] Board { get; }
        int Area { get; }
        void CheckBoardPosition(Position position);
        Position GetRandomPosition();
        IPlayingBoard BlockPosition(Position position);
        IPlayingBoard BlockPosition(IList<Position> blocked);
        IPlayingBoard BlockPosition(int x, int y);
        IPlayingBoard ClearBlocked();
        Size Size { get; }
        IList<Position> GetPositions();
        void Print(IList<Position> route);
    }
}
