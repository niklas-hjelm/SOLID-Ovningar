namespace WorkshopHandsOn14.States
{
    public class StateService : IStateService
    {
        public IState CurrentState { get; private set; }

        public static IStateService Create()
        {
            return new StateService();
        }
        private StateService()
        { }

        public void Execute()
        {
            this.CurrentState.Execute();
            this.CurrentState.NextState(this);
        }
        public IStateService SetState(IState state)
        {
            this.CurrentState = state;
            return this;
        }
    }
}