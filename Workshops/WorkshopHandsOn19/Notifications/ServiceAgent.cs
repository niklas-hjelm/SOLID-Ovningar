using System;
using System.Collections.Generic;
using System.Linq;
using WorkshopHandsOn19.Extensions;
using WorkshopHandsOn19.Recipients;

namespace WorkshopHandsOn19.Notifications
{
    public abstract class ServiceAgent : IServiceAgent
    {
        private IList<IRecipient> _recipients;

        protected ServiceAgent(params IRecipient[] recipients)
        {
            _recipients = recipients.ToList();
        }
        public IServiceAgent Send(string message)
        {
            _recipients.ForEach(recipient => 
            {
                Console.WriteLine($"Notifying ({recipient.Name}, {recipient.Phone}) with {this.GetType().Name}");
                recipient.Notify(message);
            });
            return this;
        }
    }
}
