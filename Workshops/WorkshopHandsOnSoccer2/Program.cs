using System;
using WorkshopHandsOnSoccer2.Common;
using WorkshopHandsOnSoccer2.Decorators;
using WorkshopHandsOnSoccer2.Players;
using WorkshopHandsOnSoccer2.Referees;
using WorkshopHandsOnSoccer2.ValueObjects;

namespace WorkshopHandsOnSoccer2
{
    class Program
    {
        static void Main(string[] args)
        {
            IFootBall ball = FootBall.Create();
            IReferee referee = Referee.Create("Gustav");

            IGoalKeeper goolie = GoalKeeper.Create("Simpson");
            IPlayer player1 = DefenderDecorator.Create(FieldPlayer.Create("1"));
            IPlayer player2 = DefenderDecorator.Create(FieldPlayer.Create("2"));
            IPlayer player3 = DefenderDecorator.Create(FieldPlayer.Create("3"));
            IPlayer player4 = FieldPlayer.Create("4");
            IPlayer player5 = FieldPlayer.Create("5");
            IPlayer player6 = FieldPlayer.Create("6");
            IPlayer player7 = FieldPlayer.Create("7");

            ball.AddObservers(referee, goolie, player1, player2, player3, player4, player5, player6, player7);
            ball.SetPosition(Position.Create(0,0,0));
            goolie.PassFootBall();

            ball.SetPosition(Position.Create(50, 47, 0));
            player1.Dribble();
            player1.PassFootBall();
            player3.PassFootBall();
            player7.ShotGoal();

            Console.ReadKey();
        }
    }
}
