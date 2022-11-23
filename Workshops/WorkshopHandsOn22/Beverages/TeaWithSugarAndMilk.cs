using System;
using WorkshopHandsOn22.Base;

namespace WorkshopHandsOn22.Beverages
{
    public class TeaWithSugarAndMilk : Beverage
    {
        private TeaWithSugarAndMilk()
        {
            Console.WriteLine($"Creating Tea with sugar and milk");
        }

        public static IBeverage Create()
        {
            return new TeaWithSugarAndMilk();
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
            Cup.Fill("Tea");
        }
    }
}
