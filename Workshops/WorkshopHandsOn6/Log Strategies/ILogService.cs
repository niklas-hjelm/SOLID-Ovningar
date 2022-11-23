using System;
using WorkshopHandsOn6.Log_Strategies;

namespace WorkshopHandsOn6.Log_Strategies
{
    public interface ILogService
    {
        void Log(string message);
        void SetLogger(LogTypes type);
    }
}
