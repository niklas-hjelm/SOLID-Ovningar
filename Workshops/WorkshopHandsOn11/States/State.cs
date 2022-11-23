using System;
using WorkshopHandsOn11.Log_Strategies;

namespace WorkshopHandsOn11.States
{
    public abstract class State<TContext> : IState<TContext>
    {
        public ILogService Logger { get; set; }

        public State()
        {
        }
        virtual public void Execute(TContext context)
        { }
    }
}
