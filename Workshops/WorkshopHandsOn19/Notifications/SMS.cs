using System;
using WorkshopHandsOn19.Recipients;

namespace WorkshopHandsOn19.Notifications
{
    public class SMS : ServiceAgent
    {
        private SMS(params IRecipient[] recipients)
            :base(recipients)
        {
        }
        public static IServiceAgent Create(params IRecipient[] recipients)
        {
            return new SMS(recipients);
        }
    }
}
