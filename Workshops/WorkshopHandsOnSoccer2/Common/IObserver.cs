using WorkshopHandsOnSoccer2.ValueObjects;

namespace WorkshopHandsOnSoccer2.Common
{
    public interface IObserver
    {
        string Name { get; }
        void Notify(Position position);
    }
}