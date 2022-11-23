using System;
using WorkshopHandsOn1.ValueObjects;
namespace WorkshopHandsOn1
{
    public interface IRobot
    {
        void MoveTo(Position position);
        void Grab();
        void Release();
        Position CurrentPosition();
    }
}
