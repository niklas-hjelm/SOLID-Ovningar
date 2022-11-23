using System;
using WorkshopHandsOn11.Commands;
using WorkshopHandsOn11.Log_Strategies;
using WorkshopHandsOn11.ExceptionChain;
using WorkshopHandsOn11.Validation;
using WorkshopHandsOn11.Algorithms;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Remoting.Messaging;
using System.Reflection;
using WorkshopHandsOn11.Messages;
using WorkshopHandsOn11.Navigation;
using WorkshopHandsOn11.Programs;

namespace WorkshopHandsOn11
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
