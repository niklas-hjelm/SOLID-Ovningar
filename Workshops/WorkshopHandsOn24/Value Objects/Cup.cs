using System;

namespace WorkshopHandsOn24.ValueObjects
{
    public class Cup
    {
        public void Fill(string drink)
        {
            Console.WriteLine($"Filling with {drink}");
        }
    }
}