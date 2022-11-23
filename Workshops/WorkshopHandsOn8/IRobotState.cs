using System;

namespace WorkshopHandsOn8
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
