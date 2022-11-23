using System;
using WorkshopHandsOn9.ValueObjects;

namespace WorkshopHandsOn9.Messages
{
    class PositionIsFreeEvent : Message<Position>
    {
        public PositionIsFreeEvent(Position position, Guid key)
            : base(position, key)
        {
        }
    }
}
