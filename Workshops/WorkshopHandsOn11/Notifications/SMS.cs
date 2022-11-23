using System;

namespace WorkshopHandsOn11.NotificationServices
{
    public class SMS : IServiceAgent
    {
        private SMS()
        {
        }
        public static SMS Create()
        {
            return new SMS();
        }
        public IServiceAgent Send(string message)
        {
            Console.WriteLine(string.Format("Sending SMS! {0}", message));
            return this;
        }
    }
}
