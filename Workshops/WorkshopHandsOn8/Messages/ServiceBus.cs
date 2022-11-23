using System;
using System.Collections.Generic;
using System.Linq;

namespace WorkshopHandsOn8.Messages
{
    public class ServiceBus : IServiceBus
    {
        private IDictionary<Type, IPublisher> _publishers = new Dictionary<Type, IPublisher>();

        public static IServiceBus Create()
        {
            return new ServiceBus();
        }
        private ServiceBus()
        {
        }
        public void Register<T>(Action<T> action)
        {
            IPublisher<T> publisher = this.TryGetPublisher<T>();
            if (publisher != null)
            {
                publisher.Register(action);
            }
            else
            {
                Publisher<T> p = new Publisher<T>();
                p.Register(action);
                this._publishers.Add(typeof(T), p);
            }
        }
        public void UnRegister<T>(Action<T> action)
        {
            IPublisher<T> publisher = this.TryGetPublisher<T>();
            if (publisher != null)
            {
                publisher.UnRegister(action);
            }
        }
        public void Publish<T>(T e)
        {
            IPublisher<T> publisher = this.TryGetPublisher<T>();
            if (publisher != null)
            {
                publisher.Publish(e);
            }
        }
        public void RemoveAll<T>()
        {
            IPublisher<T> publisher = this.TryGetPublisher<T>();
            if (publisher != null)
            {
                publisher.RemoveAll();
            }
        }
        private IPublisher<T> TryGetPublisher<T>()
        {
            if (this._publishers.ContainsKey(typeof(T)))
            {
                IPublisher o;
                if (this._publishers.TryGetValue(typeof(T), out o))
                {
                    return ((IPublisher<T>)o);
                }
            }
            return null;
        }
    }
}
