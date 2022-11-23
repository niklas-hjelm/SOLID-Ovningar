using System;

namespace WorkshopHandsOn3.Log_Strategies
{
    class PrinterLogStrategy : LogStrategy
    {
        public override void Log(string message)
        {
            Console.WriteLine(string.Format("Printer logged: {0}",message));
        }
    }
}
