using System;
using WorkshopHandsOn16.Participants;

namespace WorkshopHandsOn16.Chatrooms
{
    interface IChatroom
    {
        void Register(IParticipant participant);
        void UnRegister(IParticipant participant);
        void Send(string from, string to, string message);
    }
}
