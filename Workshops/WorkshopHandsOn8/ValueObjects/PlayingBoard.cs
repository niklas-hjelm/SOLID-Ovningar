using System;
using System.Drawing;
using WorkshopHandsOn8.Exceptions;

namespace WorkshopHandsOn8.ValueObjects
{
    class PlayingBoard : IPlayingBoard
    {
        public Size Size { get; private set; }
        public int Area { get { return Size.Width * Size.Height; } }

        private Random _random = new Random();

        public static IPlayingBoard Create(int width, int height)
        {
            return new PlayingBoard(width, height);
        }
        public void CheckBoardPosition(Position position)
        {
            if ((this.Size.Width < position.X) || (this.Size.Height < position.Y))
                throw new OffBoardException();
        }
        public Position GetRandomPosition()
        {
            int x = this._random.Next(1, this.Size.Width + 1);
            int y = this._random.Next(1, this.Size.Height + 1);
            return Position.Create(x, y);
        }
        private PlayingBoard(int width, int height)
        {
            this.Size = new Size(width, height);
        }
    }
}
