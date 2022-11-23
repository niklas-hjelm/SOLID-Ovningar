using System;

namespace WorkshopHandsOn10.Log_Strategies
{
    public abstract class LogStrategy : ILogStrategy
    {
        public abstract void Log(string message);
        public abstract void Log(string message, bool newLine);
    }
}
