using System;
using WorkshopHandsOn22.Base;

namespace WorkshopHandsOn22.Beverages
{
    public class Tea : Beverage
    {
        private Tea()
        {
            Console.WriteLine($"Creating Tea");
        }

        public static IBeverage Create()
        {
            return new Tea();
        }
    }
}
