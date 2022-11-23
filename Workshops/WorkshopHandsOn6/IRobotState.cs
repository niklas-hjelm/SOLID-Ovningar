using System;

namespace WorkshopHandsOn6
{
    public interface IRobotState
    {
        bool IsPowerOn();
        bool CanWalk();
        IRobotState SetCanWalkOn();
        IRobotState SetCanWalkOff();
        IRobotState SetPowerOn();
        IRobotState SetPowerOff();
    }
}
