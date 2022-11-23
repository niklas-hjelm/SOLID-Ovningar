namespace WorkshopHandsOn19.Notifications
{
    public class NotificationService : INotificationService
    {
        private IServiceAgent _agent;

        private NotificationService()
        {
        }

        public static INotificationService Create()
        {
            return new NotificationService();
        }

        public static INotificationService Create(IServiceAgent agent)
        {
            INotificationService service = new NotificationService();
            service.SetServiceAgent(agent);
            return service;
        }

        public INotificationService SetServiceAgent(IServiceAgent agent)
        {
            this._agent = agent;
            return this;
        }
        public INotificationService Send(string message)
        {
            this._agent.Send(message);
            return this;
        }
    }
}
