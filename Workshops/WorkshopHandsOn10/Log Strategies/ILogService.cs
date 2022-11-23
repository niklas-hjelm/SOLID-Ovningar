using System;
using WorkshopHandsOn10.Log_Strategies;

namespace WorkshopHandsOn10.Log_Strategies
{
    public interface ILogService
    {
        void Log(string message);
        void Log(string message, bool newLine);
        void SetLogger(LogTypes type);
    }
}
