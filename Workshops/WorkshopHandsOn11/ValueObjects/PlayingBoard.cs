using System;
using System.Linq;
using System.Drawing;
using WorkshopHandsOn11.Exceptions;
using System.Collections.Generic;
using WorkshopHandsOn11.Log_Strategies;

namespace WorkshopHandsOn11.ValueObjects
{
    class PlayingBoard : IPlayingBoard
    {
        public Tile[,] Board { get; private set; }
        public Size Size { get; private set; }
        public int Area { get { return Size.Width * Size.Height; } }
        private ILogService _logger;

        private Random _random = new Random();

        public static IPlayingBoard Create(int width, int height)
        {
            return new PlayingBoard(width, height, null);
        }
        public static IPlayingBoard Create(int width, int height, ILogService logger)
        {
            return new PlayingBoard(width, height, logger);
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
        public IList<Position> GetPositions()
        {
            IList<Position> result = new List<Position>();
            for (int x = 1; x <= this.Size.Width; x++)
            {
                for (int y = 1; y <= this.Size.Height; y++)
                {
                    result.Add(Position.Create(x, y));
                }
            }
            return result;
        }
        public IPlayingBoard ClearBlocked()
        {
            for (int x = 0; x < this.Size.Width; x++)
            {
                for (int y = 0; y < this.Size.Height; y++)
                {
                    this.Board[x, y].CanPass = true;
                }
            }
            return this;
        }
        public IPlayingBoard BlockPosition(Position position)
        {
            return this.BlockPosition(position.X, position.Y);
        }
        public IPlayingBoard BlockPosition(int x, int y)
        {
            this.CheckBoardPosition(Position.Create(x, y));
            this.Board[x - 1, y - 1].CanPass = false;
            return this;
        }
        public IPlayingBoard BlockPosition(IList<Position> blocked)
        {
            foreach (Position p in blocked)
            {
                this.Board[p.X - 1, p.Y - 1].CanPass = false;
            }
            return this;
        }
        public void Print(IList<Position> route)
        {
            string[,] map = new string[this.Size.Width, this.Size.Height];

            for (int x = 0; x < this.Size.Width; x++)
            {
                for (int y = 0; y < this.Size.Height; y++)
                {
                    map[x, y] = this.Board[x, y].CanPass ? "  < , >  " : "  <x,x>  ";
                }
            }

            foreach (Position p in route)
            {
                map[p.X - 1, p.Y - 1] = string.Format("  <{0},{1}>  ", p.X, p.Y);
            }

            this._logger.Log("", true);
            for (int y = 0; y < this.Size.Height; y++)
            {
                for (int x = 0; x < this.Size.Width; x++)
                {
                    this._logger.Log(map[x, y].ToString(), false);
                }
                this._logger.Log("", true);
            }
            this._logger.Log("", true);
        }
        private PlayingBoard(int width, int height, ILogService logger)
        {
            this.Size = new Size(width, height);
            this.InitializeGameBoard();
            this._logger = logger;
        }
        private void InitializeGameBoard()
        {
            this.Board = new Tile[this.Size.Width, this.Size.Height];
            for (var x = 0; x < this.Size.Width; x++)
            {
                for (var y = 0; y < this.Size.Height; y++)
                {
                    this.Board[x, y] = Tile.Create(x, y);
                }
            }
            AllTiles.ToList().ForEach(o => o.FindNeighbours(Board));
        }
        private IEnumerable<Tile> AllTiles
        {
            get
            {
                for (var x = 0; x < this.Size.Width; x++)
                    for (var y = 0; y < this.Size.Height; y++)
                        yield return Board[x, y];
            }
        }
    }
}
