using System;

namespace WorkshopHandsOn14.States
{
    public interface IState
    {
        void Execute();
        void NextState(IStateService service);
    }
}
