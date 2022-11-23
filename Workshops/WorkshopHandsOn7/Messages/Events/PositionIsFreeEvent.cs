using System;
using WorkshopHandsOn7.ValueObjects;

namespace WorkshopHandsOn7.Messages
{
    class PositionIsFreeEvent : Message<Position>
    {
        public PositionIsFreeEvent(Position position, Guid key)
            : base(position, key)
        {
        }
    }
}
