using System;
using WorkshopHandsOn10.Messages;
using WorkshopHandsOn10.Log_Strategies;

namespace WorkshopHandsOn10.MessageHandlers
{
    public class MailCommandHandler : IMessageHandler<SendMailCommand>
    {
        private IServiceBus _servicebus;
        private ILogService _logger;

        public static MailCommandHandler Create(IServiceBus servicebus, ILogService logger)
        {
            return new MailCommandHandler(servicebus, logger);
        }
        private MailCommandHandler(IServiceBus servicebus, ILogService logger)
        {
            this._logger = logger;
            this._servicebus = servicebus;
            this._servicebus.Register<SendMailCommand>(e => ((IMessageHandler<SendMailCommand>)this).Execute(e));
        }
        void IMessageHandler<SendMailCommand>.Execute(SendMailCommand message)
        {
            this._logger.Log(string.Format("Receiving MailCommand. Mail:{0}", message.Data.ToString()));
        }
    }
}
