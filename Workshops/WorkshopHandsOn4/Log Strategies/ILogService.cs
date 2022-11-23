using System;
using WorkshopHandsOn4.Log_Strategies;

namespace WorkshopHandsOn4.Log_Strategies
{
    public interface ILogService
    {
        void Log(string message);
        void SetLogger(LogTypes type);
    }
}
