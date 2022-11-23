using System;
using WorkshopHandsOn7.ValueObjects;
using WorkshopHandsOn7.Validation;

namespace WorkshopHandsOn7
{
    public interface IRobot : IValidatable<IRobot>, IRobotState
    {
        void MoveTo(Position position);
        void MoveToAnyFreePosition();
        void Grab(Func<IRobot, object> func);
        void Release(Func<IRobot, object> func);
        Position CurrentPosition();
        string Name { get; }
        Guid ID { get; }
    }
}
