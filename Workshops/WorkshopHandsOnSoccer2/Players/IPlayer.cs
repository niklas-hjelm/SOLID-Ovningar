using WorkshopHandsOnSoccer2.Common;

namespace WorkshopHandsOnSoccer2.Players
{
    public interface IPlayer : IObserver
    {
        IPlayer PassFootBall();
        IPlayer ShotGoal();
        IPlayer Dribble();
    }
}