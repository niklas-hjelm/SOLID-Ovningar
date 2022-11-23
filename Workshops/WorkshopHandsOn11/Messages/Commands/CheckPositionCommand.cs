using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WorkshopHandsOn11.ValueObjects;

namespace WorkshopHandsOn11.Messages
{
    class CheckPositionCommand : Message<Position>
    {
        public CheckPositionCommand(Position position, Guid key)
            :base(position, key)
        {
        }
    }
}
