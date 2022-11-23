using System;

namespace WorkshopHandsOn12.Units
{
    public class Fan : IElectricalUnit
    {
        public static IElectricalUnit Create()
        {
            return new Fan();
        }
         private Fan()
        {}
        public void On()
        {
            Console.WriteLine(string.Format("{0} is toggled On", this.GetType().Name));
        }
        public void Off()
        {
            Console.WriteLine(string.Format("{0} is toggled Off", this.GetType().Name));
        }
    }
}
