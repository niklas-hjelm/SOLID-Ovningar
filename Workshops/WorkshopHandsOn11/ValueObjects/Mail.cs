using System;

namespace WorkshopHandsOn11.ValueObjects
{
    public class Mail
    {
        public string Sender { get; set; }
        public string Reciever { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }

        public static Mail Create()
        {
            return new Mail();
        }
        private Mail()
        {
            this.Sender =string.Empty;
            this.Reciever = string.Empty;
            this.Subject = string.Empty;
            this.Message = string.Empty;
        }
        public override string ToString()
        {
            return string.Format("Sender: {0}, Reciever: {1}, Subject: {2}, Message: {3}", this.Sender, this.Reciever, this.Subject, this.Message);
        }
    }
}
