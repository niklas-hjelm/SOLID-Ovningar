using System;

namespace WorkshopHandsOn6.Messages
{
    public interface IMessage<TDataContainer>
    {
        TDataContainer Data { get; }
        DateTime Created { get; }
        bool IsSender(Guid key);
    }
}
