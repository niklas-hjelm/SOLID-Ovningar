using System;

namespace WorkshopHandsOn12.Switches
{
    public class FancySwitch : Switch
    {
        public static ISwitch Create()
        {
            return new FancySwitch();
        }
        private FancySwitch()
        {}
        public override string Name
        {
            get { return "FancySwitch"; }
        }
    }
}
