using System;

namespace WorkshopHandsOn10.ValueObjects
{
    class ParkingLot 
    {
        public Position Position { get; private set;}

        public static ParkingLot Create()
        {
            return new ParkingLot(-1, -1);
        }
        public static ParkingLot Create(int x, int y)
        {
            return new ParkingLot(x, y);
        }
        private ParkingLot(int x, int y)
        {
            this.Position = Position.Create(x, y);
        }
    }
}
