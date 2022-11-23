using System;
using System.Linq;
using WorkshopHandsOn24.Base;
using WorkshopHandsOn24.Behavoirs;

namespace WorkshopHandsOn24.Beverages
{
    public class HouseBlendCoffe : Beverage
    {
        private HouseBlendCoffe(params ICondimentBehavoir[] condiments)
        {
            Console.WriteLine("Creating House Blend Coffe");
            Description = !condiments.Any() ? "House Blend Coffee" : "House Blend Coffee With ";
            Cost = 9;
            AddCondiment(condiments);
        }
        public static IBeverage Create(params ICondimentBehavoir[] condiments)
        {
            return new HouseBlendCoffe(condiments);
        }
    }
}
