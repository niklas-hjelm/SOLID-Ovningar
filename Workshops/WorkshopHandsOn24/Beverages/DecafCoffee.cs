using System;
using System.Linq;
using WorkshopHandsOn24.Base;
using WorkshopHandsOn24.Behavoirs;

namespace WorkshopHandsOn24.Beverages
{
    public class DecafCoffee : Beverage
    {
        private DecafCoffee(params ICondimentBehavoir[] condiments)
        {
            Console.WriteLine("Creating Decaf Coffee");
            Description = !condiments.Any() ? "Decaf Coffe" : "Decaf Coffee With ";
            Cost = 9;
            AddCondiment(condiments);
        }
      
        public static IBeverage Create(params ICondimentBehavoir[] condiments)
        {
            return new DecafCoffee(condiments);
        }
    }
}
