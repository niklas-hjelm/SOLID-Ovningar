using System;
using WorkshopHandsOn9.ValueObjects;
using WorkshopHandsOn9.Validation;
using System.Collections.Generic;

namespace WorkshopHandsOn9
{
    public interface IRobot : IValidatable<IRobot>, IRobotState
    {
        void Move(IList<Position> route);
        void MoveTo(Position position);
        void ForceMoveTo(Position position);
        void MoveToAnyFreePosition();
        void Grab(Func<IRobot, object> func);
        void Release(Func<IRobot, object> func);
        Position CurrentPosition();
        void SetCurrentPosition(Position position);
        string Name { get; }
        Guid ID { get; }
    }
}
