
using System;
using WorkshopHandsOn22.Base;

namespace WorkshopHandsOn22.Beverages
{
    public class Coffee : Beverage
    {
        private Coffee()
        {
            Console.WriteLine($"Creating Coffee");
        }

        public static IBeverage Create()
        {
            return new Coffee();
        }
    }
}
