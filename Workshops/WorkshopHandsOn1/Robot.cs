using System;
using WorkshopHandsOn1.ValueObjects;

namespace WorkshopHandsOn1
{
    public class Robot : IRobot
    {
        private Position _position = Position.Create();

        public static IRobot Create()
        {
            return new Robot();
        }
        private Robot()
        {}
        public void MoveTo(Position position)
        {
            this._position = Position.Create(position);
            Console.WriteLine("Robot moved to Position({0},{1}).", this._position.X, this._position.Y);
        }
        public void Release()
        {
            Console.WriteLine("Robot sat down the box on Position({0},{1}).", this._position.X, this._position.Y);
        }
        public void Grab()
        {
            Console.WriteLine("Robot picked up the box on Position({0},{1}).", this._position.X, this._position.Y);
        }
        public Position CurrentPosition()
        {
            return this._position;
        }
    }
}
