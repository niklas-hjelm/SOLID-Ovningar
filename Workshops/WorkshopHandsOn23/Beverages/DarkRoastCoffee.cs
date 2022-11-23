
using System;
using WorkshopHandsOn23.Base;

namespace WorkshopHandsOn23.Beverages
{
    public class DarkRoastCoffee : Beverage
    {
        private DarkRoastCoffee()
        {
            Console.WriteLine("Creating Dark Roast Coffee");
            Description = "Dark Roast Coffee";
            Cost = 11;
        }
        public static IBeverage Create()
        {
            return new DarkRoastCoffee();
        }
        protected override void PourInCup()
        {
            Cup.Fill(Description);
        }
    }
}
