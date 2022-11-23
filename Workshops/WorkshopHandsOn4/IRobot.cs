using System;
using WorkshopHandsOn4.ValueObjects;
using WorkshopHandsOn4.Validation;

namespace WorkshopHandsOn4
{
    public interface IRobot : IValidatable<IRobot>, IRobotState
    {
        void MoveTo(Position position);
        void Grab();
        void Release();
        Position CurrentPosition();
    }
}
