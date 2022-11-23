using System;
using WorkshopHandsOn16.Chatrooms;
using WorkshopHandsOn16.Participants;

namespace WorkshopHandsOn16
{
    class Program
    {
        static void Main(string[] args)
        {
            IChatroom room = Chatroom.Create();
            IParticipant john = Beatle.Create("John", room);
            IParticipant paul = Beatle.Create("Paul", room);
            IParticipant ringo = Beatle.Create("Ringo", room);
            IParticipant george = Beatle.Create("George", room);

            paul.Send("Ringo", "All you need is lowe.");
            ringo.Send("George", "My sweet lord.");
            paul.Send("John", "Can't by me lowe.");
            john.Send("Paul", "All you need is drugs.");
            george.Send("Ringo", "Help!");

            Console.ReadKey();
        }
    }
}
