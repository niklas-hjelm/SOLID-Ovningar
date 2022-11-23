using System;
using WorkshopHandsOnSoccer1.Common;
using WorkshopHandsOnSoccer1.ValueObjects;

namespace WorkshopHandsOnSoccer1.Players
{
    public class Player : Observer, IPlayer
    {
        private Position _ballPosition;

        private Player(string name) : base(name)
        {}

        public static IPlayer Create(string name)
        {
            return new Player(name);
        }

        public override void Notify(Position position)
        {
            _ballPosition = position;
            Console.WriteLine($"Player {Name} say that the ball is at {_ballPosition.X},{_ballPosition.Y},{_ballPosition.Z}");
        }
    }
}
