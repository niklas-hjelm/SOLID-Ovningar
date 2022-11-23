using WorkshopHandsOnSoccer2.Common;

namespace WorkshopHandsOnSoccer2.ValueObjects
{
    public interface IFootBall
    {
        IFootBall SetPosition(Position position);
        Position GetPosition();
        void AddObservers(params IObserver[] observers);
    }
}