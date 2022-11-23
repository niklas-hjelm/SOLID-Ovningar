using System;
using WorkshopHandsOn3.ValueObjects;
using WorkshopHandsOn3.Validation;

namespace WorkshopHandsOn3
{
    public interface IRobot : IValidatable<IRobot>, IRobotState
    {
        void MoveTo(Position position);
        void Grab();
        void Release();
        Position CurrentPosition();
    }
}
