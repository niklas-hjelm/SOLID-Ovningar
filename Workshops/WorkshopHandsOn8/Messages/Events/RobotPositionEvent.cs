using System;
using WorkshopHandsOn8.ValueObjects;

namespace WorkshopHandsOn8.Messages
{
    class RobotPositionEvent : Message<Position>
    {
        public RobotPositionEvent(Position position, Guid key)
           : base(position, key)
        {
        }
    }
}
