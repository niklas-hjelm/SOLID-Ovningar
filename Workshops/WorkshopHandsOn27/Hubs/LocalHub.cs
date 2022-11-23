using System;
using System.Collections.Generic;
using WorkshopHandsOn27.Computers;
using WorkshopHandsOn27.ValueObjects;

namespace WorkshopHandsOn27.Hubs
{
    public class LocalHub : ILocalHub
    {
        public string Name { get; protected set; }
        public string NetworkId { get; protected set; }
        private IDictionary<string, IComputer> _computers = new Dictionary<string, IComputer>();

        public static ILocalHub Create(string name) => new LocalHub(name, Guid.NewGuid().ToString());

        private LocalHub(string name, string networkId)
        {
            Name = name;
            NetworkId = networkId;
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
                _computers[message.RecipientNetworkId?.NetworkId].Receive(message.SenderNetworkId?.NetworkId, message.Text);
            }
         }

        public void Receive(Message message)
        {
            if (IsForMe(message))
            {
                _computers[message.RecipientNetworkId?.NetworkId].Receive(message.SenderNetworkId?.NetworkId, message.Text);
            }
        }

        public void Broadcast(Message message)
        {
            Console.WriteLine($"Region({Name}) broadcasting({message.Text}).");
            foreach (IComputer p in _computers.Values)
            {
                if (!p.NetworkId.Equals(message.SenderNetworkId?.NetworkId))
                    p.Receive(message.SenderNetworkId?.NetworkId, message.Text);
            }
        }

        public void Dispose()
        {
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
