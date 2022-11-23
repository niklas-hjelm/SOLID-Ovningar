using System;
using WorkshopHandsOn22.Base;

namespace WorkshopHandsOn22.Beverages
{
    public class TeaWithMilk : Beverage
    {
        private TeaWithMilk()
        {
            Console.WriteLine($"Creating Tea with milk");
        }

        public static IBeverage Create()
        {
            return new TeaWithMilk();
        }

        protected override void AddMilk()
        {
            Cup.Add("milk");
        }

        protected override void PourInCup()
        {
            Cup.Fill("Tea");
        }
    }
}
