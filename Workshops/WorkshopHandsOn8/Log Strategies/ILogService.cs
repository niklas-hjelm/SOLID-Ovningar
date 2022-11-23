using System;
using WorkshopHandsOn8.Log_Strategies;

namespace WorkshopHandsOn8.Log_Strategies
{
    public interface ILogService
    {
        void Log(string message);
        void SetLogger(LogTypes type);
    }
}
