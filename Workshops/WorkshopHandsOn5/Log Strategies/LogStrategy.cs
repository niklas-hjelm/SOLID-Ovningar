using System;

namespace WorkshopHandsOn5.Log_Strategies
{
    public abstract class LogStrategy : ILogStrategy
    {
        public abstract void Log(string message);
    }
}
