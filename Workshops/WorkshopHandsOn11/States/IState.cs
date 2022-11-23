using System;
using WorkshopHandsOn11.Log_Strategies;

namespace WorkshopHandsOn11.States
{
    public interface IState<TContext>
    {
        ILogService Logger { get; set; }
        void Execute(TContext context);
    }
}
