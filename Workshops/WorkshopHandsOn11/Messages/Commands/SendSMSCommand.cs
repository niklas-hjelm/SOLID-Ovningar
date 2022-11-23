using System;
using WorkshopHandsOn11.ValueObjects;

namespace WorkshopHandsOn11.Messages
{
    class SendSMSCommand : Message<SMS>
    {
        public static SendSMSCommand Create(SMS message, Guid key)
        {
            return new SendSMSCommand(message, key);
        }
        private SendSMSCommand(SMS message, Guid key)
            : base(message, key)
        {
        }
    }
}
