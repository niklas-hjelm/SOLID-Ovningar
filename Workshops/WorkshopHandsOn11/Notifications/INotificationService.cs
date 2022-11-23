using System;

namespace WorkshopHandsOn11.NotificationServices
{
    public interface INotificationService
    {
        INotificationService Send(string message);
        INotificationService AddServiceAgents(params IServiceAgent[] agents);
    }
}
