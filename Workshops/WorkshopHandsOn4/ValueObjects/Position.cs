using System;
using System.Drawing;

namespace WorkshopHandsOn4.ValueObjects
{
    public class Position
    {
        public int X { get { return this.Current.X; } }
        public int Y { get { return this.Current.Y; } }
        private Point Current { get; set; }

        public static Position Create()
        {
            return new Position();
        }
        public static Position Create(int x, int y)
        {
            return new Position(x, y);
        }
        public static Position Create(Position position)
        {
            return new Position(position.Current.X, position.Current.Y);
        }
        private Position()
            : this(0, 0)
        {
        }
        private Position(int x, int y)
        {
            this.Current = new Point(x, y);
        }
        public bool Equals(Position obj)
        {
            return this.Current.Equals(new Point(obj.X, obj.Y));
        }
        public override string ToString()
        {
            return $"(X:{X}; Y:{Y})";;
        }
    }
}
