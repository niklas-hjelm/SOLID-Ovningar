using System;

namespace WorkshopHandsOn22.ValueObjects
{
    public class Cup
    {
        public void Fill(string drink)
        {
            Console.WriteLine($"Filling with {drink}");
        }

        public void Add(string extra)
        {
            Console.WriteLine($"Adding {extra}");
        }
    }
}