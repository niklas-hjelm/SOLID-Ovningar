using System;

namespace WorkshopHandsOn28.ValueObjects
{
    public class Message
    {
        public NetworkID SenderNetworkId { get; protected set; }
        public NetworkID RecipientNetworkId { get; protected set; }
        public string Text { get; protected set; }

        public static Message Create(NetworkID sender, string text) => new Message(sender, NetworkID.Create(string.Empty, string.Empty, string.Empty), text);
        public static Message Create(NetworkID sender, NetworkID recipient, string text) => new Message(sender, recipient, text);

        public bool IsSameLocalNetwork()
        {
            return SenderNetworkId == null ? false : SenderNetworkId.LocalNetworkId.Equals(RecipientNetworkId.LocalNetworkId);
        }

        private Message(NetworkID sender, NetworkID recipient, string text)
        {
            SenderNetworkId = sender;
            RecipientNetworkId = recipient;
            Text = text;
        }
    }
}
