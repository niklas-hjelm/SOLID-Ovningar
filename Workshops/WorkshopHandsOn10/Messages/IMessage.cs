using System;

namespace WorkshopHandsOn10.Messages
{
    public interface IMessage<TDataContainer>
    {
        TDataContainer Data { get; }
        DateTime Created { get; }
        bool IsSender(Guid key);
        /// <summary>
        /// Gets the information about the message.
        /// </summary>
        /// <returns>
        /// A Tuple with (SenderKey, MessageData).
        /// </returns>
        Tuple<Guid, TDataContainer> GetInformation();
    }
}
