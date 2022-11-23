using System;
using WorkshopHandsOn16.Chatrooms;

namespace WorkshopHandsOn16.Participants
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
            Console.WriteLine(string.Format("To a Beatle({0}): {1} from {2}", Name, message, from));
        }
    }
}
