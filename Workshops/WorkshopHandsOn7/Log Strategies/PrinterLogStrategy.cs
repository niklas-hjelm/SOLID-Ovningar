using System;

namespace WorkshopHandsOn7.Log_Strategies
{
    class PrinterLogStrategy : LogStrategy
    {
        public override void Log(string message)
        {
            Console.WriteLine(string.Format("Printer logged: {0}",message));
        }
    }
}
