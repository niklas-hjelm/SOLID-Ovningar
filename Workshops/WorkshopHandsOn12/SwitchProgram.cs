using System;
using WorkshopHandsOn12.Units;
using WorkshopHandsOn12.Switches;

namespace WorkshopHandsOn12
{
    public static class SwitchProgram
    {
        public static void Run()
        {
            Console.WriteLine("EXECUTING Switches.");

            IElectricalUnit unit = Fan.Create();
            ISwitch sw = FancySwitch.Create().SetElectricalUnit(unit);
            sw.On().Off();

            sw = StandardSwitch.Create().SetElectricalUnit(unit);
            sw.On().Off();

            unit = Light.Create();
            sw = FancySwitch.Create().SetElectricalUnit(unit);
            sw.On().Off();

            sw = StandardSwitch.Create().SetElectricalUnit(unit);
            sw.On().Off();
        }
    }
    //EXECUTING Switches.
    //Fan toggled On
    //FancySwitch toggled On
    //Fan toggled Off
    //FancySwitch toggled Off
    //Fan toggled On
    //StandardSwitch toggled On
    //Fan toggled Off
    //StandardSwitch toggled Off
    //Light toggled On
    //FancySwitch toggled On
    //Light toggled Off
    //FancySwitch toggled Off
    //Light toggled On
    //StandardSwitch toggled On
    //Light toggled Off
    //StandardSwitch toggled Off
}
