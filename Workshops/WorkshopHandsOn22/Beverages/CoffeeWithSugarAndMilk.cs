using System;
using WorkshopHandsOn22.Base;

namespace WorkshopHandsOn22.Beverages
{
    public class CoffeeWithSugarAndMilk : Beverage
    {
        private CoffeeWithSugarAndMilk()
        {
            Console.WriteLine($"Creating Coffee with sugar and milk");
        }

        public static IBeverage Create()
        {
            return new CoffeeWithSugarAndMilk();
        }

        protected override void AddSugar()
        {
            Cup.Add("sugar");
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
