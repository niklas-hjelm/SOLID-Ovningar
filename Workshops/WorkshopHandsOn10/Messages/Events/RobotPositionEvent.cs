using System;
using WorkshopHandsOn10.ValueObjects;

namespace WorkshopHandsOn10.Messages
{
    class RobotPositionEvent : Message<Position>
    {
        public RobotPositionEvent(Position position, Guid key)
            :base(position, key)
        {
        }
    }
}
