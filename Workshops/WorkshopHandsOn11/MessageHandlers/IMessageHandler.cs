using System;

namespace WorkshopHandsOn11.MessageHandlers
{
    public interface IMessageHandler<T>
    {
        void Execute(T message);
    }
}
