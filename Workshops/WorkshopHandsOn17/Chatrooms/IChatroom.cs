using System;
using WorkshopHandsOn17.Participants;

namespace WorkshopHandsOn17.Chatrooms
{
    interface IChatroom
    {
        void Register(IParticipant participant);
        void UnRegister(IParticipant participant);
        void Send(string from, string to, string message);
        void Broadcast(string from, string message);
    }
}
