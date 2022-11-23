using System;

namespace WorkshopHandsOn10.Log_Strategies
{
    public interface ILogStrategy
    {
        void Log(string message);
        void Log(string message, bool newLine);
    }
}
