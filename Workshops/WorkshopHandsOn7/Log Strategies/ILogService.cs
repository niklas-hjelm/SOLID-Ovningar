using System;
using WorkshopHandsOn7.Log_Strategies;

namespace WorkshopHandsOn7.Log_Strategies
{
    public interface ILogService
    {
        void Log(string message);
        void SetLogger(LogTypes type);
    }
}
