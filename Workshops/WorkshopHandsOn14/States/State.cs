namespace WorkshopHandsOn14.States
{
    public abstract class State : IState
    {
        public State()
        {}

        abstract public void Execute();
        virtual public void NextState(IStateService service)
        {}
    }
}
