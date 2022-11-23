using System;

namespace WorkshopHandsOn12.Switches
{
    public class StandardSwitch : Switch
    {
        public static ISwitch Create()
        {
            return new StandardSwitch();
        }
        private StandardSwitch()
        {}
        public override string Name
        {
            get { return "StandardSwitch"; }
        }
    }
}
