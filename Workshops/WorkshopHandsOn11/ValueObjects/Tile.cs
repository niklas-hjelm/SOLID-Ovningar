using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using WorkshopHandsOn11.Interfaces;

namespace WorkshopHandsOn11.ValueObjects
{
    public class Tile : IHasNeighbours<Tile>
    {
        public int X { get { return this._position.X; } }
        public int Y { get { return this._position.Y; } }
        public bool CanPass { get; set; }    
        public IEnumerable<Tile> Neighbours { get { return this.AllNeighbours.Where(o => o.CanPass); } }

        private IEnumerable<Tile> AllNeighbours { get; set; }
        private Point _position = new Point();

        public static Tile Create(int x, int y)
        {
            return new Tile(x, y);
        }
        private Tile(int x, int y)
        {
            this._position.X = x;
            this._position.Y = y;
            this.CanPass = true;
        }      
        public void FindNeighbours(Tile[,] board)
        {
            var neighbours = new List<Tile>();
            var possibleExits = this._position.X % 2 == 0 ? EvenNeighbours : OddNeighbours;

            foreach (var vector in possibleExits)
            {
                var neighbourX = this._position.X + vector.X;
                var neighbourY = this._position.Y + vector.Y;

                if (neighbourX >= 0 && neighbourX < board.GetLength(0) && neighbourY >= 0 && neighbourY < board.GetLength(1))
                    neighbours.Add(board[neighbourX, neighbourY]);
            }
            this.AllNeighbours = neighbours;
        }
        private IList<Point> EvenNeighbours
        {
            get
            {
                return new List<Point>
                {
                    new Point(0, 1),
                    new Point(1, 1),
                    new Point(1, 0),
                    new Point(0, -1),
                    new Point(-1, 0),
                    new Point(-1, 1),
                };
            }
        }
        private IList<Point> OddNeighbours
        {
            get
            {
                return new List<Point>
                {
                    new Point(0, 1),
                    new Point(1, 0),
                    new Point(1, -1),
                    new Point(0, -1),
                    new Point(-1, 0),
                    new Point(-1, -1),
                };
            }
        }
        public override string ToString()
        {
            return string.Format("[{0}, {1}]", this.X, this.Y);
        }
    }
}
