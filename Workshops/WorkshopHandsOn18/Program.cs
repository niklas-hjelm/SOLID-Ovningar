using System;
using WorkshopHandsOn18.Commands;
using WorkshopHandsOn18.Managers;
using WorkshopHandsOn18.Workers;

namespace WorkshopHandsOn18
{
    class Program
    {
        static void Main(string[] args)
        {
            IManager manager = new Manager(new CommandDispatcher());

            IWorker worker = new People("Kalle");
            manager.Register(worker);

            worker = new Robot("RoboCop");
            manager.Register(worker);

            manager.StartWorking();

            manager.TakeLunch();

            manager.StartWorking();

            Console.ReadKey();
        }
    }
}
