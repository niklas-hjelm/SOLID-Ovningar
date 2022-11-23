
using System;
using WorkshopHandsOn23.Base;

namespace WorkshopHandsOn23.Beverages
{
    public class ExpressoCoffee : Beverage
    {
        private ExpressoCoffee()
        {
            Console.WriteLine("Creating Expresso Coffee");
            Description = "Expresso Coffee";
            Cost = 15;
        }

        public static IBeverage Create()
        {
            return new ExpressoCoffee();
        }
        protected override void PourInCup()
        {
            Cup.Fill(Description);
        }
    }
}
