using System;
using WorkshopHandsOn10.ValueObjects;
using WorkshopHandsOn10.Validation;
using System.Collections.Generic;

namespace WorkshopHandsOn10
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
