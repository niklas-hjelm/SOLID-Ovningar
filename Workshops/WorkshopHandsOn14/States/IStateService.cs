using System;

namespace WorkshopHandsOn14.States
{
    public interface IStateService
    {
        void Execute();
        IStateService SetState(IState state);
        IState CurrentState { get; }
    }
}