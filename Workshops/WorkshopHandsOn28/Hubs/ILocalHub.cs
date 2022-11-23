using System;
using WorkshopHandsOn28.Computers;
using WorkshopHandsOn28.ValueObjects;

namespace WorkshopHandsOn28.Hubs
{
    public interface ILocalHub : IDisposable
    {
        string Name { get; }
        string NetworkId { get; }
        ILocalHub Register(IComputer hub);
        ILocalHub UnRegister(IComputer hub);
        void Broadcast(Message message);
        void Receive(Message message);
        void Send(Message message);
    }
}