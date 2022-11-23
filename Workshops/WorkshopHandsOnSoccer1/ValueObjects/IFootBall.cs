using WorkshopHandsOnSoccer1.Common;

namespace WorkshopHandsOnSoccer1.ValueObjects
{
    public interface IFootBall
    {
        IFootBall SetPosition(Position position);
        Position GetPosition();
        void AddObservers(params IObserver[] observers);
    }
}