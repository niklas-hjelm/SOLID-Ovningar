using System;

namespace WorkshopHandsOn24.Behavoirs
{
    public class Sugar : ICondimentBehavoir
    {
        public Tuple<int, string> Execute()
        {
            return Tuple.Create(2, "Sugar");
        }
    }
}
