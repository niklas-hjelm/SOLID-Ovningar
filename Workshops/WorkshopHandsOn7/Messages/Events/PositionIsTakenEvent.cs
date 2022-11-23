using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WorkshopHandsOn7.ValueObjects;

namespace WorkshopHandsOn7.Messages
{
    class PositionIsTakenEvent : Message<Boolean>
    {
        public PositionIsTakenEvent(Boolean isTaken, Guid key)
            : base(isTaken, key)
        {
        }
    }
}
