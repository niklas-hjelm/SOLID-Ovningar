using System;

namespace WorkshopHandsOn5
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
