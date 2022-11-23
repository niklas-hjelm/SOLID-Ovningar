using WorkshopHandsOn19.Recipients;

namespace WorkshopHandsOn19.Notifications
{
    public class InformationMessage : ServiceAgent
    {
        private InformationMessage(params IRecipient[] recipients)
            :base(recipients)
        {
        }
        public static IServiceAgent Create(params IRecipient[] recipients)
        {
            return new InformationMessage(recipients);
        }
    }
}
