using System;
using WorkshopHandsOn10.ValueObjects;

namespace WorkshopHandsOn10.Messages
{
    class PositionIsFreeEvent : Message<Position>
    {
        public PositionIsFreeEvent(Position position, Guid key)
           : base(position, key)
        {
        }
    }
}
