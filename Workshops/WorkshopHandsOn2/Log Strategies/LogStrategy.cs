using System;

namespace WorkshopHandsOn2.Log_Strategies
{
    public abstract class LogStrategy : ILogStrategy
    {
        public abstract void Log(string message);
    }
}
