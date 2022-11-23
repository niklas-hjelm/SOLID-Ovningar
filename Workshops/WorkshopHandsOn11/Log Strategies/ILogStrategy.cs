using System;

namespace WorkshopHandsOn11.Log_Strategies
{
    public interface ILogStrategy
    {
        void Log(string message);
        void Log(string message, bool newLine);
    }
}
