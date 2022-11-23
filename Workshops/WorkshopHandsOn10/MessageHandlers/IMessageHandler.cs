using System;

namespace WorkshopHandsOn10.MessageHandlers
{
    public interface IMessageHandler<T>
    {
        void Execute(T message);
    }
}
