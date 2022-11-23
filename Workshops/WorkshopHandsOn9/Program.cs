using System;
using WorkshopHandsOn9.Commands;
using WorkshopHandsOn9.Log_Strategies;
using WorkshopHandsOn9.ExceptionChain;
using WorkshopHandsOn9.Validation;
using WorkshopHandsOn9.Algorithms;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Remoting.Messaging;
using System.Reflection;
using WorkshopHandsOn9.Messages;
using WorkshopHandsOn9.Navigation;
using WorkshopHandsOn9.Programs;

namespace WorkshopHandsOn9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program2Robots.Execute();
            //ProgramRandom.Execute();
            ProgramRoute.Execute();
        }
    }
}
