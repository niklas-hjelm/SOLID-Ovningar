using System;

namespace WorkshopHandsOn17.Participants
{
    interface IParticipant : IDisposable
    {
        string Name { get; }
        void Send(string to, string message);
        void Receive(string from, string message);
        void Broadcast(string message);
    }
}
