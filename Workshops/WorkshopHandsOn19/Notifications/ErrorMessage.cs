using WorkshopHandsOn19.Recipients;

namespace WorkshopHandsOn19.Notifications
{
    public class ErrorMessage : ServiceAgent
    {
        private ErrorMessage(params IRecipient[] recipients)
            :base(recipients)
        {
        }
        public static IServiceAgent Create(params IRecipient[] recipients)
        {
            return new ErrorMessage(recipients);
        }
    }
}
