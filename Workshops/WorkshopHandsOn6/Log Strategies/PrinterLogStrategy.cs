using System;

namespace WorkshopHandsOn6.Log_Strategies
{
    class PrinterLogStrategy : LogStrategy
    {
        public override void Log(string message)
        {
            Console.WriteLine(string.Format("Printer logged: {0}",message));
        }
    }
}
