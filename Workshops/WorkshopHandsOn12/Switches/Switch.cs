using System;
using WorkshopHandsOn12.Units;

namespace WorkshopHandsOn12.Switches
{
    public abstract class Switch : ISwitch
    {
        public IElectricalUnit ElectricalUnit { get; private set; }
        public abstract string Name { get; }

        public ISwitch SetElectricalUnit(IElectricalUnit unit)
        {
            this.ElectricalUnit = unit;
            return this;
        }
        public ISwitch On()
        {
            Console.WriteLine(string.Format("{0} is toggled On", this.GetType().Name));
            ElectricalUnit.On();
            return this;
        }
        public ISwitch Off()
        {
            Console.WriteLine(string.Format("{0} is toggled Off", this.GetType().Name));
            ElectricalUnit.Off();
            return this;
        }
    }
}
