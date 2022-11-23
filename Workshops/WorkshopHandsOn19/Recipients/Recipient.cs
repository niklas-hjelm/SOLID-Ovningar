using System;

namespace WorkshopHandsOn19.Recipients
{
    public class Recipient : IRecipient
    {
        public string Name { get; protected set; }
        public string Phone { get; protected set; }
        public string EMail { get; protected set; }

        private Recipient(string name, string phone, string email)
        {
            Name = name;
            Phone = phone;
            EMail = email;
        }

        public static IRecipient Create(string name, string phone)
        {
            return new Recipient(name, phone, string.Empty);
        }

        public static IRecipient Create(string name, string phone, string email)
        {
            return new Recipient(name, phone, email);
        }

        public void Notify(string message)
        {
            Console.WriteLine($"I'm notified ({Name}) with Message: ({message})");
            Console.WriteLine(string.Empty);
        }
    }
}
