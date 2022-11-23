using System;
using WorkshopHandsOn23.Base;
using WorkshopHandsOn23.Beverages;
using WorkshopHandsOn23.Decorators;
using WorkshopHandsOn23.ValueObjects;

namespace WorkshopHandsOn23
{
    class Program
    {
        static void Main(string[] args)
        {
            // Template Method Pattern and Decorator Pattern
            IBeverage drink = DarkRoastCoffee.Create();
            Cup cup = drink.PrepareDrink();

            Console.WriteLine($"Beverage ({drink.Description}), Cost = {drink.Cost}");
            Console.WriteLine(string.Empty);

            drink = new WhipDecorator(drink);
            cup = drink.PrepareDrink();

            Console.WriteLine($"Beverage ({drink.Description}), Cost = {drink.Cost}");
            Console.WriteLine(string.Empty);

            drink = new SugarDecorator(HouseBlendCoffe.Create());
            cup = drink.PrepareDrink();

            Console.WriteLine($"Beverage ({drink.Description}), Cost = {drink.Cost}");
            Console.WriteLine(string.Empty);

            Console.ReadKey();
        }
    }
}
