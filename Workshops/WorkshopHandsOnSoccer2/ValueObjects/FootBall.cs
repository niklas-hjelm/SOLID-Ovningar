using System.Collections.Generic;
using WorkshopHandsOnSoccer2.Common;

namespace WorkshopHandsOnSoccer2.ValueObjects
{
    public class FootBall : IFootBall
    {
        private Position _ballPosition;
        private List<IObserver> _observers;

        private FootBall()
        {
            _observers = new List<IObserver>();
        }

        public static IFootBall Create()
        {
            return new FootBall();
        }

        public void AddObservers(params IObserver[] observers)
        {
            _observers.AddRange(observers);
        }

        public Position GetPosition()
        {
            return _ballPosition;
        }

        public IFootBall SetPosition(Position position)
        {
            _ballPosition = position;
            _observers.ForEach(o => o.Notify(_ballPosition));
            return this;
        }
    }
}
