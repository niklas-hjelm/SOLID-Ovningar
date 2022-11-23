using System;
using WorkshopHandsOn27.Computers;
using WorkshopHandsOn27.ValueObjects;

namespace WorkshopHandsOn27.Hubs
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