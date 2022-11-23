using System;
using WorkshopHandsOn24.Behavoirs;
using WorkshopHandsOn24.ValueObjects;

namespace WorkshopHandsOn24.Base
{
    public abstract class Beverage : IBeverage
    {
        protected Cup Cup { get; } = new Cup();
        public string Description { get; protected set; } = "Unknown Beverage";
        public double Cost { get; protected set; } = 0;

        public Cup PrepareDrink()
        {
            Cup.Fill(Description);
            return Cup;
        }
        protected void AddCondiment(params ICondimentBehavoir[] condiments)
        {
            if (condiments == null)
                return;

            foreach (ICondimentBehavoir n in condiments)
            {
                Tuple<int, string> extras = n.Execute();
                Description += $"{extras.Item2},";
                Cost += extras.Item1;
            }
            Description = Description.Substring(0, Description.Length - 1);
        }
    }
}
