using System;
using WorkshopHandsOn2.ValueObjects;

namespace WorkshopHandsOn2
{
    public interface IRobot
    {
        void MoveTo(Position position);
        void Grab();
        void Release();
        Position CurrentPosition();
    }
}
