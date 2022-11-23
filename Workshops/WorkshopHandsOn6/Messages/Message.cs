using System;

namespace WorkshopHandsOn6.Messages
{
    public abstract class Message<TDataContainer> : IMessage<TDataContainer>
    {
        public Message(Guid key)
        {
            this.Created = DateTime.Now;
            this.Key = key;
        }
        public Message(TDataContainer arg, Guid key)
            : this(key)
        {
            this.Data = arg;
        }
        public TDataContainer Data { get; private set; }
        public DateTime Created { get; private set; }
        protected Guid Key { get; set; }

        public bool IsSender(Guid key)
        {
            return Key.Equals(key);
        }
    }
}