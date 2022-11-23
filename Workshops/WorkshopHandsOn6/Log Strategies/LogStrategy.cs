using System;

namespace WorkshopHandsOn6.Log_Strategies
{
    public abstract class LogStrategy : ILogStrategy
    {
        public abstract void Log(string message);
    }
}
