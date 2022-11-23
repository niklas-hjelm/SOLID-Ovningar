using System;
using WorkshopHandsOn11.ValueObjects;

namespace WorkshopHandsOn11.Messages
{
    class RobotPositionEvent : Message<Position>
    {
        public RobotPositionEvent(Position position, Guid key)
            :base(position, key)
        {
        }
    }
}
