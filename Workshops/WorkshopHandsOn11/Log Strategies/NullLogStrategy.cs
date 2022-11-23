using System;

namespace WorkshopHandsOn11.Log_Strategies
{
    class NullLogStrategy : LogStrategy
    {
        public override void Log(string message)
        {
            Console.WriteLine(string.Format("Null logged: {0}", message));
        }
        public override void Log(string message, bool newLine)
        {
            if (newLine)
                Console.WriteLine(string.Format("Null logged: {0}", message));
            else
                Console.Write(string.Format("Null logged: {0}", message));
        }
    }
}
