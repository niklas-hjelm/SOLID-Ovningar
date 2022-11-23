using System;
using WorkshopHandsOnSoccer2.Players;

namespace WorkshopHandsOnSoccer2.Decorators
{
    public class DefenderDecorator : PlayerDecorator
    {
        private DefenderDecorator(IFieldPlayer player) : base(player)
        {
        }

        public static IPlayer Create(IFieldPlayer player)
        {
            return new DefenderDecorator(player);
        }

        public override IPlayer Dribble()
        {
            Console.WriteLine($"Defender {Player.Name} should not dribble!");
            return this;
        }

        public override IPlayer PassFootBall()
        {
            return Player.PassFootBall();
        }

        public override IPlayer ShotGoal()
        {
            return Player.ShotGoal();
        }
    }
}
