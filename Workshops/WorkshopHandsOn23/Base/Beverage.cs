using System;
using WorkshopHandsOn23.ValueObjects;

namespace WorkshopHandsOn23.Base
{
    public abstract class Beverage : IBeverage
    {
        protected Cup Cup { get; } = new Cup();
        public string Description { get; protected set; } = "Unknown Beverage";
        public double Cost { get; protected set; } = 0;

        public Cup PrepareDrink()
        {
            BoilWater();
            PourInCup();
            return Cup;
        }

        protected virtual void PourInCup()
        {
            Cup.Fill("water"); 
        }
     
        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }
    }
}
