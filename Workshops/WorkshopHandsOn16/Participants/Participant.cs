using System;
using WorkshopHandsOn16.Chatrooms;

namespace WorkshopHandsOn16.Participants
{
    abstract class Participant : IParticipant
    {
        public string Name { get; protected set; }
        protected IChatroom Chatroom { get; set; }

        public Participant(string name, IChatroom chatroom)
        {
            Name = name;
            Chatroom = chatroom;
            chatroom.Register(this);
        }

        public void Send(string to, string message)
        {
            Chatroom.Send(Name, to, message);
        }

        public void Dispose()
        {
            Chatroom.UnRegister(this);
        }
        public abstract void Receive(string from, string message);
    }
}
