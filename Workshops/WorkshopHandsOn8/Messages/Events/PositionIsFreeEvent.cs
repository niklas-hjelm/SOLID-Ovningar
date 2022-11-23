using System;
using WorkshopHandsOn8.ValueObjects;

namespace WorkshopHandsOn8.Messages
{
    class PositionIsFreeEvent : Message<Position>
    {
        public PositionIsFreeEvent(Position position, Guid key)
            : base(position, key)
        {
        }
    }
}
