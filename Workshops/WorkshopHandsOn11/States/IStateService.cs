using System;

namespace WorkshopHandsOn11.States
{
    public interface IStateService<TContext>
    {
        TContext Context { get; }
        void Execute(IState<TContext> state);
        IStateService<TContext> SetData(TContext context);
    }
}
