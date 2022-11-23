using System;

namespace WorkshopHandsOn8.Log_Strategies
{
    class FileLogStrategy : LogStrategy
    {
       public override void Log(string message)
        {
            Console.WriteLine(string.Format("File logged: {0}",message));
        }
    }
}
