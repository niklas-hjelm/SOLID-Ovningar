using System;

namespace WorkshopHandsOn10.ValueObjects
{
    public class Mail
    {
        public string Sender { get; set; }
        public string Reciever { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }

        public override string ToString()
        {
            return string.Format("Sender: {0}, Reciever: {1}, Subject: {2}, Message: {3}", this.Sender, this.Reciever, this.Subject, this.Message);
        }
    }
}
