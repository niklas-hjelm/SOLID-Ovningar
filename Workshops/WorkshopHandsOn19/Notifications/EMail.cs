using System;
using WorkshopHandsOn19.Recipients;

namespace WorkshopHandsOn19.Notifications
{
    public class EMail : ServiceAgent
    {
        private EMail(params IRecipient[] recipients)
            :base(recipients)
        {
        }
        public static IServiceAgent Create(params IRecipient[] recipients)
        {
            return new EMail(recipients);
        }
     }
}
