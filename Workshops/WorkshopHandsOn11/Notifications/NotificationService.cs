using System;
using System.Collections.Generic;
using System.Linq;

namespace WorkshopHandsOn11.NotificationServices
{
    public class NotificationService : INotificationService
    {
        private Lazy<IList<IServiceAgent>> _agents = new Lazy<IList<IServiceAgent>>(() => new List<IServiceAgent>());

        private NotificationService()
        {
        }
        private NotificationService(params IServiceAgent[] agents)
        {
            foreach (var agent in agents)
            {
                this._agents.Value.Add(agent);
            }
        }
        public static NotificationService Create()
        {
            return new NotificationService();
        }
        public static NotificationService Create(params IServiceAgent[] agents)
        {
            return new NotificationService(agents);
        }
        public INotificationService AddServiceAgents(params IServiceAgent[] agents)
        {
            foreach (var agent in agents)
            {
                this._agents.Value.Add(agent);
            }
            return this;
        }
        public INotificationService Send(string message)
        {
            foreach (var agent in _agents.Value)
            {
                agent.Send(message);
            }
            return this;
        }
    }
}
