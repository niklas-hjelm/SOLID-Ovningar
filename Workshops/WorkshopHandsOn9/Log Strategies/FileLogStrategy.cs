using System;

namespace WorkshopHandsOn9.Log_Strategies
{
    class FileLogStrategy : LogStrategy
    {
       public override void Log(string message)
        {
            Console.WriteLine(string.Format("File logged: {0}", message));
        }
       public override void Log(string message, bool newLine)
       {
           if (newLine)
               Console.WriteLine(string.Format("File logged: {0}", message));
           else
               Console.Write(string.Format("File logged: {0}", message));
       }
    }
}
