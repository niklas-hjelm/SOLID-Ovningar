using System;
using WorkshopHandsOn12.Units;

namespace WorkshopHandsOn12.Switches
{
    public interface ISwitch
    {
        ISwitch SetElectricalUnit(IElectricalUnit unit);
        ISwitch On();
        ISwitch Off();
    }
}
