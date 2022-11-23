using System;
using WorkshopHandsOn17.Chatrooms;

namespace WorkshopHandsOn17.Participants
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

        public void Broadcast(string message)
        {
            Chatroom.Broadcast(Name, message);
        }
    }
}
