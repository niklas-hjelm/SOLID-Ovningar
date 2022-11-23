using System;

namespace WorkshopHandsOn8.Messages
{
    public interface IPublisher<T> : IPublisher
    {
        void Publish(T e);
        void Register(Action<T> action);
        void RemoveAll();
        void UnRegister(Action<T> action);
    }
    public interface IPublisher
    {
    }
}
