using System;

namespace WorkshopHandsOn11.NotificationServices
{
    public interface IServiceAgent
    {
        IServiceAgent Send(string message);
    }
}
