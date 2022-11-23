using System;
using System.Linq;
using WorkshopHandsOn24.Base;
using WorkshopHandsOn24.Behavoirs;

namespace WorkshopHandsOn24.Beverages
{
    public class ExpressoCoffee : Beverage
    {
        private ExpressoCoffee(params ICondimentBehavoir[] condiments)
        {
            Console.WriteLine("Creating Expresso Coffee");
            Description = !condiments.Any() ? "Expresso Coffee" : "Expresso Coffee With ";
            Cost = 15;
            AddCondiment(condiments);
        }
      
        public static IBeverage Create(params ICondimentBehavoir[] condiments)
        {
            return new ExpressoCoffee(condiments);
        }
    }
}
