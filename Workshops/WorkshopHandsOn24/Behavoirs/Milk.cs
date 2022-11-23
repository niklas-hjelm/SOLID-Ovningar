using System;

namespace WorkshopHandsOn24.Behavoirs
{
    public class Milk : ICondimentBehavoir
    {
        public Tuple<int, string> Execute()
        {
            return Tuple.Create(2, "Milk");
        }
    }
}
