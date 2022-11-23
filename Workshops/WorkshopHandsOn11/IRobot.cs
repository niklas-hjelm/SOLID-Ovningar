using System;
using WorkshopHandsOn11.ValueObjects;
using WorkshopHandsOn11.Validation;
using System.Collections.Generic;

namespace WorkshopHandsOn11
{
    public interface IRobot : IValidatable<IRobot>, IRobotState
    {
        void Move(IList<Position> route);
        IRobot MoveTo(Position position);
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
