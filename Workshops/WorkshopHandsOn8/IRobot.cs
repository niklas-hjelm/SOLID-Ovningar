using System;
using WorkshopHandsOn8.ValueObjects;
using WorkshopHandsOn8.Validation;

namespace WorkshopHandsOn8
{
    public interface IRobot : IValidatable<IRobot>, IRobotState
    {
        void MoveTo(Position position);
        void ForceMoveTo(Position position);
        void MoveToAnyFreePosition();
        void Grab(Func<IRobot, object> func);
        void Release(Func<IRobot, object> func);
        Position CurrentPosition();
        string Name { get; }
        Guid ID { get; }
    }
}
