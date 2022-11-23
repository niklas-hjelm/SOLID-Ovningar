using WorkshopHandsOnSoccer2.ValueObjects;
using WorkshopHandsOnSoccer2.Players;

namespace WorkshopHandsOnSoccer2.Decorators
{
    public abstract class PlayerDecorator : IFieldPlayer
    {
        protected IFieldPlayer Player { get; }

        public string Name { get { return Player.Name; } }

        protected PlayerDecorator(IFieldPlayer player)
        {
            Player = player;
        }

        public void Notify(Position position)
        {
            Player.Notify(position);
        }

        public abstract IPlayer Dribble();

        public abstract IPlayer PassFootBall();

        public abstract IPlayer ShotGoal();
    }
}
