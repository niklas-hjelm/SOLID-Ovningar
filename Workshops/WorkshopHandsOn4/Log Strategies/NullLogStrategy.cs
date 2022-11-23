using System;

namespace WorkshopHandsOn4.Log_Strategies
{
    class NullLogStrategy : LogStrategy
    {
        public override void Log(string message)
        {
            Console.WriteLine(string.Format("Null logged: {0}",message));
        }
    }
}
