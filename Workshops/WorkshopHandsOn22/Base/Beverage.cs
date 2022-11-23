using System;
using WorkshopHandsOn22.ValueObjects;

namespace WorkshopHandsOn22.Base
{
    public abstract class Beverage : IBeverage
    {
        protected Cup Cup { get; } = new Cup();

        public Cup PrepareDrink()
        {
            BoilWater();
            PourInCup();
            AddSugar();
            AddMilk();
            return Cup;
        }

        protected virtual void AddSugar()
        {
        }

        protected virtual void AddMilk()
        {
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
