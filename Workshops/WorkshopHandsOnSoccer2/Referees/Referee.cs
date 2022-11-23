using System;
using WorkshopHandsOnSoccer2.Common;
using WorkshopHandsOnSoccer2.ValueObjects;

namespace WorkshopHandsOnSoccer2.Referees
{
    public class Referee : Observer, IReferee
    {
        private Position _ballPosition;

        private Referee(string name) : base(name)
        {
        }

        public static IReferee Create(string name)
        {
            return new Referee(name);
        }

        public override void Notify(Position position)
        {
            _ballPosition = position;
            Console.WriteLine($"Referee {Name} say that the ball is at {_ballPosition.X},{_ballPosition.Y},{_ballPosition.Z}");
        }
    }
}
