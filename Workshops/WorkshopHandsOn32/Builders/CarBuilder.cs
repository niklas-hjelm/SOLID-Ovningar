using System;
using System.Drawing;
using WorkshopHandsOn32.Containers;
using WorkshopHandsOn32.Extensions;
using WorkshopHandsOn32.Vehicles;

namespace WorkshopHandsOn32.Builders
{
    class CarBuilder : Builder<IGenericContainer, ICar>
    {
        private CarBuilder(IGenericContainer container) : base(container)
        { }

        public static IBuilder<IGenericContainer, ICar> Create(IGenericContainer container)
        {
            return new CarBuilder(container);
        }

        public override ICar Build(IGenericContainer container)
        {
            string type = container.GetValue<string>(BuildTypes.Car);
            Color color = container.GetValue<Color>(CarOptions.Color);
            string driveChain = container.GetValue<string>(CarOptions.DriveChain);
            "Building Car {0} with {1} and {2}!".DoFormat(type, color, driveChain).ToConsole();
            return new Car(type, color, driveChain);
        }
    }
}
