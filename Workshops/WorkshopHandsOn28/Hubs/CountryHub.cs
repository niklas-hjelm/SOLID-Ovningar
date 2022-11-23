using System;
using System.Collections.Generic;
using WorkshopHandsOn28.ValueObjects;

namespace WorkshopHandsOn28.Hubs
{
    public class CountryHub : ICountryHub
    {
        public string Name { get; protected set; }
        public string NetworkId { get; protected set; }
        private IInternet Internet { get; set; }
        private IDictionary<string, ILocalHub> _hubs = new Dictionary<string, ILocalHub>();

        public static ICountryHub Create(string name, IInternet internet) => new CountryHub(name, Guid.NewGuid().ToString(), internet);

        protected CountryHub(string name, string networkId, IInternet internet)
        {
            Name = name;
            NetworkId = networkId;
            Internet = internet;
            Internet.Register(this);
        }

        public ICountryHub Register(ILocalHub localHub)
        {
            if (!_hubs.ContainsKey(localHub.NetworkId))
                _hubs.Add(localHub.NetworkId, localHub);
            return this;
        }

        public ICountryHub UnRegister(ILocalHub localHub)
        {
            if (_hubs.ContainsKey(localHub.NetworkId))
                _hubs.Remove(localHub.NetworkId);
            return this;
        }

        public void Send(Message message)
        {
            if (NetworkId.Equals(message.RecipientNetworkId.CountryNetworkId))
            {
                if (IsRecipientNetwork(message))
                {
                    _hubs[message.RecipientNetworkId.LocalNetworkId].Send(message);
                }
            }
            else
            {
                Internet.Send(message);
            }
        }

        public void Receive(Message message)
        {
            if (IsRecipientNetwork(message))
            {
                _hubs[message.RecipientNetworkId.LocalNetworkId].Receive(message);
            }
        }

        public void Broadcast(Message message)
        {
            Console.WriteLine(string.Empty);
            Console.WriteLine($"Country({Name}) broadcasting({message.Text}).");
            foreach (ILocalHub p in _hubs.Values)
            {
                NetworkID sender = NetworkID.Create(this.NetworkId, p.NetworkId, this.NetworkId);
                NetworkID recipient = NetworkID.Create(this.NetworkId, p.NetworkId, p.NetworkId);
                message = Message.Create(sender, recipient, message.Text);
                p.Broadcast(message);
            }
        }

        public void Dispose()
        {
            Internet = null;
            foreach (ILocalHub p in _hubs.Values)
            {
                UnRegister(p);
                p.Dispose();
            }
        }

        private bool IsRecipientNetwork(Message message)
        {
            return _hubs.ContainsKey(message.RecipientNetworkId.LocalNetworkId);
        }
    }
}
