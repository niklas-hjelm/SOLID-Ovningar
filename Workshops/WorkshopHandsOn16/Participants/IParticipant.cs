using System;
using WorkshopHandsOn16.Chatrooms;

namespace WorkshopHandsOn16.Participants
{
    interface IParticipant : IDisposable
    {
        string Name { get; }
        void Send(string to, string message);
        void Receive(string from, string message);
    }
}
