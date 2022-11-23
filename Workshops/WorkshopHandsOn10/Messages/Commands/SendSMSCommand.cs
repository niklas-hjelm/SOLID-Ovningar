using System;
using WorkshopHandsOn10.ValueObjects;

namespace WorkshopHandsOn10.Messages
{
    public class SendSMSCommand : Message<SMS>
    {
        public SendSMSCommand(SMS message, Guid key)
            : base(message, key)
        {
        }
    }
}
