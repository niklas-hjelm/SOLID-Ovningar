using System;
using WorkshopHandsOn27.ValueObjects;

namespace WorkshopHandsOn27.Computers
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