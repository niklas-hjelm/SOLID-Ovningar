using WorkshopHandsOn21.IceCreams;

namespace WorkshopHandsOn21.Builders
{
    interface IIceCreamBuilder
    {
        IIceCream Build();
        IceCreamBuilder Caramel(int spoon);
        IceCreamBuilder Cherry(int number);
        IceCreamBuilder Flavor(FlavorTypes flavor);
        IceCreamBuilder Peanuts(int spoon);
        IceCreamBuilder Type(IceCreamTypes type);
    }
}