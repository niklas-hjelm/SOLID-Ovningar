using System;
using WorkshopHandsOn17.Chatrooms;
using WorkshopHandsOn17.Participants;

namespace WorkshopHandsOn17
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
            IParticipant yoko = Friend.Create("Yoko", room);
            IParticipant fan = Friend.Create("Fan", room);

            paul.Send("Ringo", "All you need is lowe.");
            ringo.Send("George", "My sweet lord.");
            paul.Send("John", "Can't by me lowe.");
            john.Send("Paul", "All you need is drugs.");

            yoko.Send("John", "Hi John!");
            fan.Broadcast("My sweet lowe to all of you!");

            john.Broadcast("All you need is drugs.");

            Console.ReadKey();
        }
    }
}
