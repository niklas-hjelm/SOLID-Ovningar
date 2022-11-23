using System;
using WorkshopHandsOn6.ValueObjects;
using WorkshopHandsOn6.Validation;

namespace WorkshopHandsOn6
{
    public interface IRobot : IValidatable<IRobot>, IRobotState
    {
        void MoveTo(Position position);
        void Grab(Func<IRobot, object> func);
        void Release(Func<IRobot, object> func);
        Position CurrentPosition();
        string Name { get; }
    }
}
