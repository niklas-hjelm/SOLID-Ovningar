using System;

namespace WorkshopHandsOn10.ValueObjects
{
    public class SMS
    {
        public string Message { get; private set; }

        public SMS(string message)
        {
            this.Message = message;
        }
        public override string ToString()
        {
            return string.Format("Message: {0}", this.Message);
        }
    }
}
