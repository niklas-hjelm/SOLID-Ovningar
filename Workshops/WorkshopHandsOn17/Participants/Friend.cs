using System;
using WorkshopHandsOn17.Chatrooms;

namespace WorkshopHandsOn17.Participants
{
    class Friend : Participant
    {
        public static IParticipant Create(string name, IChatroom chatroom)
        {
            return new Friend(name, chatroom);
        }

        private Friend(string name, IChatroom chatroom)
            :base(name, chatroom)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.WriteLine($"Friend({Name}) received ({message}) from {from}");
        }
    }
}
