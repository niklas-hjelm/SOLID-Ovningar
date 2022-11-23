using System;

namespace WorkshopHandsOn11
{
    public interface IRobotState
    {
        bool IsPowerOn();
        bool CanWalk();
        bool InStelthMode();
        IRobotState SetCanWalkOn();
        IRobotState SetCanWalkOff();
        IRobotState SetPowerOn();
        IRobotState SetPowerOff();
        IRobotState SetStelthModeOn();
        IRobotState SetStelthModeOff();
        IRobotState Reset();
    }
}
