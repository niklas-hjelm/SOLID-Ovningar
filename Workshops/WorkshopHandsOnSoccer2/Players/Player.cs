using System;
using WorkshopHandsOnSoccer2.Common;
using WorkshopHandsOnSoccer2.ValueObjects;

namespace WorkshopHandsOnSoccer2.Players
{
    public abstract class Player : Observer, IPlayer
    {
        private Position _ballPosition;

        protected Player(string name) : base(name)
        {
        }

        public IPlayer Dribble()
        {
            Console.WriteLine($"Player {Name} dribble's successfully!");
            return this;
        }

        public override void Notify(Position position)
        {
            _ballPosition = position;
            Console.WriteLine($"Player {Name} say that the ball is at {_ballPosition.X},{_ballPosition.Y},{_ballPosition.Z}.");
        }

        public IPlayer PassFootBall()
        {
            Console.WriteLine($"Player {Name} passes the ball!");
            return this;
        }

        public IPlayer ShotGoal()
        {
            Console.WriteLine($"Player {Name} scores a goa!");
            return this;
        }
    }
}
