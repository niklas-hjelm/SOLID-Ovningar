using System;
using WorkshopHandsOn5.Log_Strategies;

namespace WorkshopHandsOn5.Log_Strategies
{
    public interface ILogService
    {
        void Log(string message);
        void SetLogger(LogTypes type);
    }
}
