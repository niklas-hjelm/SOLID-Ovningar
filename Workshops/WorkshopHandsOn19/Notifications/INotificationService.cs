namespace WorkshopHandsOn19.Notifications
{
    public interface INotificationService
    {
        INotificationService Send(string message);
        INotificationService SetServiceAgent(IServiceAgent agent);
    }
}
