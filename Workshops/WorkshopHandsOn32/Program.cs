using System;
using System.Drawing;
using WorkshopHandsOn32.Builders;
using WorkshopHandsOn32.Containers;
using WorkshopHandsOn32.Extensions;
using WorkshopHandsOn32.Vehicles;

namespace BuilderPattern.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            IGenericContainer carContainer = GenericContainer.Create();
            carContainer
                .SetValue(BuildTypes.Car, "BMW")
                .SetValue(CarOptions.Color, Color.White)
                .SetValue(CarOptions.DriveChain, "AWD");

            IBuilder<IGenericContainer, ICar> builder = CarBuilder.Create(carContainer);
            ICar car = builder.Build(carContainer);

            "My {0} has {1} and is a {2}!".DoFormat(car.TypeOf, car.Color, car.DriveChain).ToConsole(true);


            IGenericContainer bicycleContainer = GenericContainer.Create();
            bicycleContainer
                .SetValue(BuildTypes.Bicycle, "MTB")
                .SetValue(BicycleOptions.Gears, 10)
                .SetValue(BicycleOptions.Color, Color.White);

            IBuilder<IGenericContainer, IBicycle> bicycleBuilder = BicycleBuilder.Create(bicycleContainer);
            IBicycle cycle = bicycleBuilder.Build(bicycleContainer);

            "My {0} has {1} gears and has {2}!".DoFormat(cycle.TypeOf, cycle.Gears, cycle.Color).ToConsole();

            Console.ReadKey();
        }
    }
}
