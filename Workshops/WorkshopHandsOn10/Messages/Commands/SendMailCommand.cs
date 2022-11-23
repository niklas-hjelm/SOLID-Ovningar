using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WorkshopHandsOn10.ValueObjects;

namespace WorkshopHandsOn10.Messages
{
    public class SendMailCommand : Message<Mail>
    {
        public SendMailCommand(Mail message, Guid key)
            : base(message, key)
        {
        }
    }
}
