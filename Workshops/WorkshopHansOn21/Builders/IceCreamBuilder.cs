using WorkshopHandsOn21.IceCreams;

namespace WorkshopHandsOn21.Builders
{
    class IceCreamBuilder : IIceCreamBuilder
    {
        private IIceCream _cream;

        private IceCreamBuilder()
        {
            _cream = new IceCream();
        }

        public static IIceCreamBuilder Create()
        {
            return new IceCreamBuilder();
        }

        public IIceCream Build()
        {
            IIceCream cream = _cream.Copy();
            _cream.Reset();
            return cream;
        }

        public IceCreamBuilder Caramel(int spoon)
        {
            _cream.SetCaramels(spoon);
            return this;
        }

        public IceCreamBuilder Peanuts(int spoon)
        {
            _cream.SetPeanuts(spoon);
            return this;
        }
     
        public IceCreamBuilder Type(IceCreamTypes type)
        {
            _cream.SetType(type);
            return this;
        }

        public IceCreamBuilder Flavor(FlavorTypes flavor)
        {
            _cream.SetFlavor(flavor);
            return this;
        }

        public IceCreamBuilder Cherry(int number)
        {
            _cream.SetCherrys(number);
            return this;
        }
    }
}
