using System;
using WorkshopHandsOn7.ValueObjects;

namespace WorkshopHandsOn7.Messages
{
    class RobotPositionEvent : Message<Position>
    {
        public RobotPositionEvent(Position position, Guid key)
            :base(position, key)
        {
        }
    }
}
