using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WorkshopHandsOn9.ValueObjects;

namespace WorkshopHandsOn9.Messages
{
    class CheckPositionCommand : Message<Position>
    {
        public CheckPositionCommand(Position position, Guid key)
            : base(position, key)
        {
        }
    }
}
