using System;
using WorkshopHandsOn11.Log_Strategies;
using WorkshopHandsOn11.Messages;

namespace WorkshopHandsOn11.States
{
    public class StateService<TContext> : IStateService<TContext> 
    {
        public TContext Context { get; private set; }

        private ILogService _logger;
        private IServiceBus _servicebus;

        private StateService(ILogService logger, IServiceBus servicebus)
        {
            this._logger = logger;
            this._servicebus = servicebus;
        }
        public static IStateService<TContext> Create(ILogService logger, IServiceBus servicebus)
        {
            return new StateService<TContext>(logger, servicebus);
        }
        public IStateService<TContext> SetData(TContext context)
        {
            this.Context = context;
            return this;
        }
        public void Execute(IState<TContext> state)
        {
            this.Log(state);
            state.Logger = this._logger;
            state.Execute(this.Context);
        }
        private void Log(IState<TContext> state)
        {
            this._logger.Log(string.Format("Executing state {0} ", state.GetType().Name));
        }
     }
}
