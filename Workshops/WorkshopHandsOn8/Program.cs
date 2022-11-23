using System;
using WorkshopHandsOn8.Commands;
using WorkshopHandsOn8.Log_Strategies;
using WorkshopHandsOn8.ExceptionChain;
using WorkshopHandsOn8.Validation;
using WorkshopHandsOn8.Algorithms;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Remoting.Messaging;
using System.Reflection;
using WorkshopHandsOn8.Messages;
using WorkshopHandsOn8.Navigation;

namespace WorkshopHandsOn8
{
    class Program
    {
        static void Main(string[] args)
        {
            Program2Robots.Execute();
            //ProgramRandom.Execute();
        }
    }
}
