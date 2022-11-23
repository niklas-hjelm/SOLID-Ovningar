using System;
using WorkshopHandsOnSoccer2.ValueObjects;

namespace WorkshopHandsOnSoccer2.Players
{
    public class GoalKeeper : Player, IGoalKeeper
    {
        private Position _ballPosition;

        private GoalKeeper(string name) : base(name)
        {
        }

        public static IGoalKeeper Create(string name)
        {
            return new GoalKeeper(name);
        }

        public override void Notify(Position position)
        {
            _ballPosition = position;
            Console.WriteLine($"GoalKeeper {Name} say that the ball is at {_ballPosition.X},{_ballPosition.Y},{_ballPosition.Z}.");
        }

        public IGoalKeeper SaveShoot()
        {
            Console.WriteLine($"GoalKeeper {Name} saved the shot!");
            return this;
        }
    }
}
