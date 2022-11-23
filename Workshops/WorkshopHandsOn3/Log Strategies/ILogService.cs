using System;
using WorkshopHandsOn3.Log_Strategies;

namespace WorkshopHandsOn3.Log_Strategies
{
    public interface ILogService
    {
        void Log(string message);
        void SetLogger(LogTypes type);
    }
}
