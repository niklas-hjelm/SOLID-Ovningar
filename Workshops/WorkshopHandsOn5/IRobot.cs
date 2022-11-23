using System;
using WorkshopHandsOn5.ValueObjects;
using WorkshopHandsOn5.Validation;

namespace WorkshopHandsOn5
{
    public interface IRobot : IValidatable<IRobot>, IRobotState
    {
        void MoveTo(Position position);
        void Grab(Func<IRobot, object> func);
        void Release(Func<IRobot, object> func);
        Position CurrentPosition();
    }
}
