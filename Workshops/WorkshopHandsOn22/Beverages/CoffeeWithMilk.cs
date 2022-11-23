
using System;
using WorkshopHandsOn22.Base;

namespace WorkshopHandsOn22.Beverages
{
    public class CoffeeWithMilk : Beverage
    {
        private CoffeeWithMilk()
        {
            Console.WriteLine($"Creating Coffee with milk");
        }

        public static IBeverage Create()
        {
            return new CoffeeWithMilk();
        }

        protected override void AddMilk()
        {
            Cup.Add("milk");
        }

        protected override void PourInCup()
        {
            Cup.Fill("Coffee");
        }
    }
}
