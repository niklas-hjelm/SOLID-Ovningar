using System;

namespace WorkshopHandsOn11.Log_Strategies
{
    public abstract class LogStrategy : ILogStrategy
    {
        public abstract void Log(string message);
        public abstract void Log(string message, bool newLine);
    }
}
