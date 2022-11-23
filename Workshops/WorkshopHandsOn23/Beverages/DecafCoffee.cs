
using System;
using WorkshopHandsOn23.Base;

namespace WorkshopHandsOn23.Beverages
{
    public class DecafCoffee : Beverage
    {
        private DecafCoffee()
        {
            Console.WriteLine("Creating Coffee without Coffien");
            Description = "Coffee without Coffien";
            Cost = 9;
        }

        public static IBeverage Create()
        {
            return new DecafCoffee();
        }
        protected override void PourInCup()
        {
            Cup.Fill(Description);
        }
    }
}
