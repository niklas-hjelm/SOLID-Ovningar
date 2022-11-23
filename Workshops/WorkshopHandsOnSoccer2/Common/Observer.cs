using WorkshopHandsOnSoccer2.ValueObjects;

namespace WorkshopHandsOnSoccer2.Common
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
