using WorkshopHandsOnSoccer1.ValueObjects;

namespace WorkshopHandsOnSoccer1.Common
{
    public interface IObserver
    {
        void Notify(Position position);
    }
}