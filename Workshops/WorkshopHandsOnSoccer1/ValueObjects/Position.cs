namespace WorkshopHandsOnSoccer1.ValueObjects
{
    public class Position
    {
        public int X { get; }
        public int Y { get; }
        public int Z { get; }

        public static Position Create(int x, int y, int z)
        {
            return new Position(x, y, z);
        }

        private Position(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public bool Equals(Position obj)
        {
            return X.Equals(obj.X) && Y.Equals(obj.Y) && Z.Equals(obj.Z);
        }

        public override string ToString()
        {
            return $"(X:{X}; Y:{Y}); Z:{Z})";
        }
    }
}
