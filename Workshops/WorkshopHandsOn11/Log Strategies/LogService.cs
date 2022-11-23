using System;
using WorkshopHandsOn11.Log_Strategies;
using System.Collections.Generic;

namespace WorkshopHandsOn11.Log_Strategies
{
    public class LogService : ILogService
    {
        private IDictionary<LogTypes, Type> _actions = new Dictionary<LogTypes, Type>();
        private LogTypes _current = LogTypes.Debug;

        private LogService()
            : this(LogTypes.Debug)
        {
        }
        private LogService(LogTypes type)
        {
            this.SetupActions();
            this._current = type;
        }
        public static ILogService Create()
        {
            return new LogService();
        }
        public static ILogService Create(LogTypes type)
        {
            return new LogService(type);
        }
        private void SetupActions()
        {
            this._actions.Add(LogTypes.Debug, typeof(DebugLogStrategy));
            this._actions.Add(LogTypes.File, typeof(FileLogStrategy));
            this._actions.Add(LogTypes.Printer, typeof(PrinterLogStrategy));
            this._actions.Add(LogTypes.Null, typeof(NullLogStrategy));
        }
        public void SetLogger(LogTypes type)
        {
            this._current = type;
        }
        public void Log(string message)
        {
            ILogStrategy strategy = (ILogStrategy)Activator.CreateInstance(this._actions[_current]);
            strategy.Log(message);
        }
        public void Log(string message, bool newLine)
        {
            ILogStrategy strategy = (ILogStrategy)Activator.CreateInstance(this._actions[_current]);
            strategy.Log(message, newLine);
        }
    }
}
