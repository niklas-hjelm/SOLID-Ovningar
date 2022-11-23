using System;

namespace WorkshopHandsOn24.Behavoirs
{
    public class MilkAndSugar : ICondimentBehavoir
    {
        public Tuple<int, string> Execute()
        {
            return Tuple.Create(3, "Milk And Sugar");
        }
    }
}
