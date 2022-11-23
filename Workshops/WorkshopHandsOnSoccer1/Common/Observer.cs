using WorkshopHandsOnSoccer1.ValueObjects;

namespace WorkshopHandsOnSoccer1.Common
{
    public abstract class Observer : IObserver
    {
        public string Name { get; }

        protected Observer(string name)
        {
            Name = name;
        }

        public abstract void Notify(Position position);
    }
}
