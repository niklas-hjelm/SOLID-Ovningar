using System;
using WorkshopHandsOnSoccer1.Common;
using WorkshopHandsOnSoccer1.ValueObjects;

namespace WorkshopHandsOnSoccer1.Referees
{
    public class Referee : Observer, IReferee
    {
        private Position _ballPosition;

        private Referee(string name) : base(name)
        {}

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
