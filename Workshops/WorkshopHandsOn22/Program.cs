using System;
using WorkshopHandsOn22.Base;
using WorkshopHandsOn22.Beverages;
using WorkshopHandsOn22.ValueObjects;

namespace WorkshopHandsOn22
{
    class Program
    {
        static void Main(string[] args)
        {
            // Template Method Pattern

            IBeverage drink = Coffee.Create();
            Cup cup = drink.PrepareDrink();

            Console.WriteLine(string.Empty);

            drink = CoffeeWithMilk.Create();
            cup = drink.PrepareDrink();

            Console.WriteLine(string.Empty);

            drink = CoffeeWithSugarAndMilk.Create();
            cup = drink.PrepareDrink();

            Console.WriteLine(string.Empty);

            drink = Tea.Create();
            cup = drink.PrepareDrink();

            Console.WriteLine(string.Empty);

            drink = TeaWithMilk.Create();
            cup = drink.PrepareDrink();

            Console.WriteLine(string.Empty);

            drink = TeaWithSugarAndMilk.Create();
            cup = drink.PrepareDrink();


            Console.ReadKey();
        }
    }
}
