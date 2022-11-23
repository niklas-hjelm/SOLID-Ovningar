using System;

namespace WorkshopHandsOn11.ValueObjects
{
    public class SMS
    {
        public string Message { get; private set; }

        public static SMS Create(string message)
        {
            return new SMS(message);
        }
        private SMS(string message)
        {
            this.Message = message;
        }
        public override string ToString()
        {
            return string.Format("Message: {0}", this.Message);
        }
    }
}
