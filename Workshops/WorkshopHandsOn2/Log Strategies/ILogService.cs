using System;
using WorkshopHandsOn2.Log_Strategies;

namespace WorkshopHandsOn2.Log_Strategies
{
    public interface ILogService
    {
        void Log(string message);
        void SetLogger(LogTypes type);
    }
}
