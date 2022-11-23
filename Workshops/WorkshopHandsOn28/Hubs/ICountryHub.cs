using System;
using WorkshopHandsOn28.Computers;
using WorkshopHandsOn28.ValueObjects;

namespace WorkshopHandsOn28.Hubs
{
    public interface ICountryHub : IDisposable
    {
        string Name { get; }
        string NetworkId { get; }
        ICountryHub Register(ILocalHub hub);
        ICountryHub UnRegister(ILocalHub hub);
        void Broadcast(Message message);
        void Receive(Message message);
        void Send(Message message);
    }
}