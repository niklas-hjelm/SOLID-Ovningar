using System;
using WorkshopHandsOn9.Log_Strategies;

namespace WorkshopHandsOn9.Log_Strategies
{
    public interface ILogService
    {
        void Log(string message);
        void Log(string message, bool newLine);
        void SetLogger(LogTypes type);
    }
}
