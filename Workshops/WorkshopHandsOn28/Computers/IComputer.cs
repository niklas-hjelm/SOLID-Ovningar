using System;
using WorkshopHandsOn28.ValueObjects;

namespace WorkshopHandsOn28.Computers
{
    public interface IComputer : IDisposable
    {
        string Name { get; }
        string NetworkId { get; }
        void Broadcast(Message message);
        void Receive(string from, string message);
        void Send(Message message);
    }
}