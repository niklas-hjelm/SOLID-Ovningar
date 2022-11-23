using System;
using WorkshopHandsOn21.Builders;
using WorkshopHandsOn21.IceCreams;

namespace WorkshopHandsOn21
{
    class Program
    {
        // Builder Pattern
        static void Main(string[] args)
        {
            IIceCreamBuilder builder = IceCreamBuilder.Create();
            IIceCream cream = builder
                                    .Caramel(1)
                                    .Cherry(2)
                                    .Flavor(FlavorTypes.Banana)
                                    .Type(IceCreamTypes.Glass)
                                    .Build();
            Console.WriteLine($"Ice-Cream of Type ({cream.Type}) with ({cream.ToString()}) created");

            cream = builder
                        .Build();

            Console.WriteLine($"Ice-Cream of Type ({cream.Type}) with ({cream.ToString()}) created");

            cream = builder
                        .Peanuts(4)
                        .Build();

            Console.WriteLine($"Ice-Cream of Type ({cream.Type}) with ({cream.ToString()}) created");

            Console.ReadKey();
        }
    }
}
