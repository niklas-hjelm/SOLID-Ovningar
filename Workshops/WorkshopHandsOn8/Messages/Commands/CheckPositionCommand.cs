using System;
using WorkshopHandsOn8.ValueObjects;

namespace WorkshopHandsOn8.Messages
{
    class CheckPositionCommand : Message<Position>
    {
        public CheckPositionCommand(Position position, Guid key)
            : base(position, key)
        {
        }
    }
}
