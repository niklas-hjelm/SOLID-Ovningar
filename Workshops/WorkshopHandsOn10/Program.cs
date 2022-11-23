using System;
using WorkshopHandsOn10.Commands;
using WorkshopHandsOn10.Log_Strategies;
using WorkshopHandsOn10.ExceptionChain;
using WorkshopHandsOn10.Validation;
using WorkshopHandsOn10.Algorithms;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Remoting.Messaging;
using System.Reflection;
using WorkshopHandsOn10.Messages;
using WorkshopHandsOn10.Navigation;
using WorkshopHandsOn10.Programs;

namespace WorkshopHandsOn10
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
