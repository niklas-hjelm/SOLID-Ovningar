using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WorkshopHandsOn11.ValueObjects;

namespace WorkshopHandsOn11.Messages
{
    class SendMailCommand : Message<Mail>
    {
        public static SendMailCommand Create(Mail message, Guid key)
        {
            return new SendMailCommand(message, key);
        }
        private SendMailCommand(Mail message, Guid key)
            : base(message, key)
        {
        }
    }
}
