using System;

namespace WorkshopHandsOn24.Behavoirs
{
    public class Whip : ICondimentBehavoir
    {
        public Tuple<int, string> Execute()
        {
            return Tuple.Create(2, "Whip");
        }
    }
}
