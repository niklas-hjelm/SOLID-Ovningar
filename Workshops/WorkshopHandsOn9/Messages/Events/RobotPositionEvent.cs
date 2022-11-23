using System;
using WorkshopHandsOn9.ValueObjects;

namespace WorkshopHandsOn9.Messages
{
    class RobotPositionEvent : Message<Position>
    {
        public RobotPositionEvent(Position position, Guid key)
            : base(position, key)
        {
        }
    }
}
