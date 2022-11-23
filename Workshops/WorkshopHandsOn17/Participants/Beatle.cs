using System;
using WorkshopHandsOn17.Chatrooms;

namespace WorkshopHandsOn17.Participants
{
    class Beatle : Participant
    {
        public static IParticipant Create(string name, IChatroom chatroom)
        {
            return new Beatle(name, chatroom);
        }

        private Beatle(string name, IChatroom chatroom)
            :base(name, chatroom)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.WriteLine($"Beatle({Name}) received ({message}) from {from}");
        }
    }
}
