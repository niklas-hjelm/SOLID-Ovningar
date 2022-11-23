using System;
using WorkshopHandsOn10.Messages;
using WorkshopHandsOn10.Log_Strategies;

namespace WorkshopHandsOn10.MessageHandlers
{
    public class SMSCommandHandler : IMessageHandler<SendSMSCommand>
    {
        private IServiceBus _servicebus;
        private ILogService _logger;

        public static SMSCommandHandler Create(IServiceBus servicebus, ILogService logger)
        {
            return new SMSCommandHandler(servicebus, logger);
        }
        private SMSCommandHandler(IServiceBus servicebus, ILogService logger)
        {
            this._logger = logger;
            this._servicebus = servicebus;
            this._servicebus.Register<SendSMSCommand>(e => ((IMessageHandler<SendSMSCommand>)this).Execute(e));
         }
        void IMessageHandler<SendSMSCommand>.Execute(SendSMSCommand message)
        {
            this._logger.Log(string.Format("Receiving SMSCommand. SMS: {0}", message.Data.ToString()));
        }
     }
}
