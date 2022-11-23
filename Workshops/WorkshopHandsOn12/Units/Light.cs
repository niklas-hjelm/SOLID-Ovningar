using System;

namespace WorkshopHandsOn12.Units
{
    public class Light : IElectricalUnit
    {
        public static IElectricalUnit Create()
        {
            return new Light();
        }
        private Light()
        {}
        public void On()
        {
            Console.WriteLine(string.Format("{0} toggled On", this.GetType().Name));
        }
        public void Off()
        {
            Console.WriteLine(string.Format("{0} toggled Off", this.GetType().Name));
        }
    }
}
