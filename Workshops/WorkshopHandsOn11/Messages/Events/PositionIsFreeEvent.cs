using System;
using WorkshopHandsOn11.ValueObjects;

namespace WorkshopHandsOn11.Messages
{
    class PositionIsFreeEvent : Message<Position>
    {
        public PositionIsFreeEvent(Position position, Guid key)
            :base(position, key)
        {
        }
    }
}
