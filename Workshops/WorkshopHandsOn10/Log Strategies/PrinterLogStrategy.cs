using System;

namespace WorkshopHandsOn10.Log_Strategies
{
    class PrinterLogStrategy : LogStrategy
    {
        public override void Log(string message)
        {
            Console.WriteLine(string.Format("Printer logged: {0}", message));
        }
        public override void Log(string message, bool newLine)
        {
            if (newLine)
                Console.WriteLine(string.Format("Printer logged: {0}", message));
            else
                Console.Write(string.Format("Printer logged: {0}", message));
        }
    }
}
