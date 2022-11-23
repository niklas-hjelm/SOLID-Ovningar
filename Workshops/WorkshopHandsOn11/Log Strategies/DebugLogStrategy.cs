using System;

namespace WorkshopHandsOn11.Log_Strategies
{
    class DebugLogStrategy : LogStrategy
    {
        public override void Log(string message)
        {
            Console.WriteLine(message);
        }
        public override void Log(string message, bool newLine)
        {
            if (newLine)
                Console.WriteLine(message);
            else
                Console.Write(message);
        }
    }
}
