using System;
using WorkshopHandsOn27.Hubs;
using WorkshopHandsOn27.ValueObjects;

namespace WorkshopHandsOn27.Computers
{
    public class Computer : IComputer
    {
        public string Name { get; protected set; }
        public string NetworkId { get; protected set; }
        protected ILocalHub Hub { get; set; }

        public static IComputer Create(string name, ILocalHub hub) => new Computer(name, Guid.NewGuid().ToString(), hub);

        private Computer(string name, string networkId, ILocalHub hub)
        {
            Name = name;
            NetworkId = networkId;
            Hub = hub;
            hub.Register(this);
        }

        public void Broadcast(Message message)
        {
            Console.WriteLine($"Computer({Name}) broadcasting({message.Text}).");
            Hub.Broadcast(message);
        }

        public void Receive(string from, string message)
        {
            Console.WriteLine($"Computer({Name}) received ({message}) from Computer({from}).");
        }

        public void Send(Message message)
        {
            Console.WriteLine($"Computer({Name}) sending ({message.Text}) to Computer({message.RecipientNetworkId?.NetworkId}).");
            Hub.Send(message);
        }

        public void Dispose()
        {
            Hub = null;
        }
    }
}
