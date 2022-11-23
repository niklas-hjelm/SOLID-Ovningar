using System;
using WorkshopHandsOn24.Base;
using WorkshopHandsOn24.Behavoirs;
using WorkshopHandsOn24.Beverages;
using WorkshopHandsOn24.ValueObjects;

namespace WorkshopHandsOn24
{
    class Program
    {
        static void Main(string[] args)
        {
            // Favor composition over inheritance

            IBeverage drink = DarkRoastCoffee.Create(new Milk());
            Cup cup = drink.PrepareDrink();

            Console.WriteLine($"Beverage ({drink.Description}), Cost = {drink.Cost}");
            Console.WriteLine(string.Empty);


            drink = DarkRoastCoffee.Create(new Sugar(), new Whip());
            cup = drink.PrepareDrink();

            Console.WriteLine($"Beverage ({drink.Description}), Cost = {drink.Cost}");
            Console.WriteLine(string.Empty);


            drink = HouseBlendCoffe.Create(new MilkAndSugar());
            cup = drink.PrepareDrink();

            Console.WriteLine($"Beverage ({drink.Description}), Cost = {drink.Cost}");
            Console.WriteLine(string.Empty);


            drink = ExpressoCoffee.Create();
            cup = drink.PrepareDrink();

            Console.WriteLine($"Beverage ({drink.Description}), Cost = {drink.Cost}");
            Console.WriteLine(string.Empty);

            Console.ReadKey();
        }
    }
}
