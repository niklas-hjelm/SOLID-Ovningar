using System;
namespace WorkshopHandsOn11.Messages
{
    public interface IServiceBus
    {
        void Publish<T>(T e);
        void Register<T>(Action<T> action);
        void RemoveAll<T>();
        void UnRegister<T>(Action<T> action);
    }
}
