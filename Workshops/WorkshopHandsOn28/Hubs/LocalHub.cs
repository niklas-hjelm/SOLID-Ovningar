using System;
using System.Collections.Generic;
using WorkshopHandsOn28.Computers;
using WorkshopHandsOn28.ValueObjects;

namespace WorkshopHandsOn28.Hubs
{
    public class LocalHub : ILocalHub
    {
        public string Name { get; protected set; }
        public string NetworkId { get; protected set; }
        private ICountryHub _countryHub;
        private IDictionary<string, IComputer> _computers = new Dictionary<string, IComputer>();

        public static ILocalHub Create(string name, ICountryHub countryHub) => new LocalHub(name, Guid.NewGuid().ToString(), countryHub);

        private LocalHub(string name, string networkId, ICountryHub countryHub)
        {
            Name = name;
            NetworkId = networkId;
            _countryHub = countryHub;
            _countryHub.Register(this);
        }

        public ILocalHub Register(IComputer pc)
        {
            if (!_computers.ContainsKey(pc.NetworkId))
                _computers.Add(pc.NetworkId, pc);
            return this;
        }

        public ILocalHub UnRegister(IComputer pc)
        {
            if (_computers.ContainsKey(pc.NetworkId))
                _computers.Remove(pc.NetworkId);
            return this;
        }

        public void Send(Message message)
        {
            if (IsForMe(message))
            {
                _computers[message.RecipientNetworkId.NetworkId].Receive(message.SenderNetworkId.Name.Equals(string.Empty) ? message.SenderNetworkId.NetworkId : message.SenderNetworkId.Name, message.Text);
            }
            else
            {
                _countryHub.Send(message);
            }
        }

        public void Receive(Message message)
        {
            if (IsForMe(message))
            {
                _computers[message.RecipientNetworkId.NetworkId].Receive(message.SenderNetworkId.NetworkId, message.Text);
            }
        }

        public void Broadcast(Message message)
        {
            Console.WriteLine($"Region({Name}) broadcasting({message.Text}).");
            foreach (IComputer p in _computers.Values)
            {
                if (!p.NetworkId.Equals(message.SenderNetworkId.NetworkId))
                {
                    NetworkID sender = NetworkID.Create(_countryHub.NetworkId, this.NetworkId, this.NetworkId);
                    NetworkID recipient = NetworkID.Create(_countryHub.NetworkId, this.NetworkId, p.NetworkId);
                    message = Message.Create(sender, recipient, message.Text);
                    p.Receive(message.SenderNetworkId.NetworkId, message.Text);
                }
            }
        }

        public void Dispose()
        {
            _countryHub.UnRegister(this);
            foreach (IComputer p in _computers.Values)
            {
                p.Dispose();
            }
        }

        private bool IsForMe(Message message)
        {
            return _computers.ContainsKey(message.RecipientNetworkId.NetworkId) && !message.SenderNetworkId.NetworkId.Equals(message.RecipientNetworkId.NetworkId);
        }
    }
}
