using System;
using WorkshopHandsOn7.ValueObjects;

namespace WorkshopHandsOn7.Messages
{
    class CheckPositionCommand : Message<Position>
    {
        public CheckPositionCommand(Position position, Guid key)
            :base(position, key)
        {
        }
    }
}
