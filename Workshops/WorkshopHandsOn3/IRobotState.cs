using System;

namespace WorkshopHandsOn3
{
    public interface IRobotState
    {
        bool IsPowerOn();
        IRobotState SetPowerOn();
        IRobotState SetPowerOff();
    }
}
