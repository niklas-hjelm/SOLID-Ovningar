using System;
using WorkshopHandsOnSoccer2.ValueObjects;

namespace WorkshopHandsOnSoccer2.Players
{
    public class FieldPlayer : Player, IFieldPlayer
    {
        private Position _ballPosition;

        protected FieldPlayer(string name) : base(name)
        {
        }

        public static IFieldPlayer Create(string name)
        {
            return new FieldPlayer(name);
        }

        public override void Notify(Position position)
        {
            _ballPosition = position;
            Console.WriteLine($"FieldPlayer {Name} say that the ball is at {_ballPosition.X},{_ballPosition.Y},{_ballPosition.Z}");
        }
    }
}
