using System;
using WorkshopHandsOnSoccer1.Players;
using WorkshopHandsOnSoccer1.Referees;
using WorkshopHandsOnSoccer1.ValueObjects;

namespace WorkshopHandsOnSoccer1
{
    class Program
    {
        static void Main(string[] args)
        {
            IFootBall ball = FootBall.Create();
            IReferee referee = Referee.Create("Referee");
            IPlayer player1 = Player.Create("1");
            IPlayer player2 = Player.Create("2");
            IPlayer player3 = Player.Create("3");
            IPlayer player4 = Player.Create("4");
            IPlayer player5 = Player.Create("5");
            IPlayer player6 = Player.Create("6");
            IPlayer player7 = Player.Create("7");

            ball.AddObservers(referee, player1, player2, player3, player4, player5, player6, player7);
            ball.SetPosition(Position.Create(0,0,0));
            ball.SetPosition(Position.Create(50, 47, 0));

            Console.ReadKey();
        }
    }
}
