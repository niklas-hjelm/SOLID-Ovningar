using System;
using WorkshopHandsOn32.Containers;
using WorkshopHandsOn32.Vehicles;
using WorkshopHandsOn32.Extensions;
using System.Drawing;

namespace WorkshopHandsOn32.Builders
{
    class BicycleBuilder : Builder<IGenericContainer, IBicycle>
    {
        private BicycleBuilder(IGenericContainer container): base(container)
        {}

        public static IBuilder<IGenericContainer, IBicycle> Create(IGenericContainer container) 
        {
            return new BicycleBuilder(container);
        }

        public override IBicycle Build(IGenericContainer container)
        {
            string type = container.GetValue<string>(BuildTypes.Bicycle);
            int gears = container.GetValue<int>(BicycleOptions.Gears);
            Color color = container.GetValue<Color>(BicycleOptions.Color);
            "Building Bicycle {0} with {1} gears and {2}!".DoFormat(type, gears, color).ToConsole();
            return new Bicycle(type, gears, color);
        }
    }
}
