
using System;
using WorkshopHandsOn23.Base;

namespace WorkshopHandsOn23.Beverages
{
    public class HouseBlendCoffe : Beverage
    {
        private HouseBlendCoffe()
        {
            Console.WriteLine("Creating House Blend Coffe");
            Description = "House Blend Coffe";
            Cost = 10;
        }

        public static IBeverage Create()
        {
            return new HouseBlendCoffe();
        }
        protected override void PourInCup()
        {
            Cup.Fill(Description);
        }
    }
}
