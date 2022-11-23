using System;
using System.Linq;
using WorkshopHandsOn24.Base;
using WorkshopHandsOn24.Behavoirs;

namespace WorkshopHandsOn24.Beverages
{
    public class DarkRoastCoffee : Beverage
    {
        private DarkRoastCoffee(params ICondimentBehavoir[] condiments)
        {
            Console.WriteLine("Creating Dark Roast Coffee");
            Description = !condiments.Any() ? "Dark Roast Coffee" : "Dark Roast Coffee With ";
            Cost = 11;
            AddCondiment(condiments);
        }
      
        public static IBeverage Create(params ICondimentBehavoir[] condiments)
        {
            return new DarkRoastCoffee(condiments);
        }
    }
}
