using System;

namespace WorkshopHandsOn11.NotificationServices
{
    public class EMail : IServiceAgent
    {
        private EMail()
        {
        }
        public static EMail Create()
        {
            return new EMail();
        }
        public IServiceAgent Send(string message)
        {
            Console.WriteLine(string.Format("Sending MailMessage! {0}", message));
            return this;
        }
    }
}
