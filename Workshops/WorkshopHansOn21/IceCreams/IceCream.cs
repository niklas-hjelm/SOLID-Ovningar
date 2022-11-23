namespace WorkshopHandsOn21.IceCreams
{
    class IceCream : IIceCream
    {
        public FlavorTypes Flavor { get; private set; }
        public IceCreamTypes Type { get; private set; }
        public int Peanuts { get; private set; }
        public int Cherrys { get; private set; }
        public int Caramels { get; private set; }
       
        public IceCream()
        {
            Flavor = FlavorTypes.Vanilla;
            Type = IceCreamTypes.Coon;
        }

        public override string ToString()
        {
            return $"Flavor: {Flavor}; With Peanuts:{(Peanuts > 0 ? true : false)}; With Cherry:{(Cherrys > 0 ? true : false)}; With Caramel:{(Caramels > 0 ? true : false)}";
        }

        void IIceCream.SetCaramels(int spoon)
        {
            Caramels = spoon;
        }

        void IIceCream.SetCherrys(int number)
        {
            Cherrys = number;
        }

        void IIceCream.SetFlavor(FlavorTypes flavor)
        {
            Flavor = flavor;
        }

        void IIceCream.SetType(IceCreamTypes type)
        {
            Type = type;
        }

        void IIceCream.SetPeanuts(int spoon)
        {
            Peanuts = spoon;
        }

        void IIceCream.Reset()
        {
            Flavor = FlavorTypes.Vanilla;
            Type = IceCreamTypes.Coon;
            Caramels = 0;
            Peanuts = 0;
            Cherrys = 0;
        }

        IIceCream IIceCream.Copy()
        {
            IIceCream cream = new IceCream();
            cream.SetType(this.Type);
            cream.SetFlavor(this.Flavor);
            cream.SetCaramels(this.Caramels);
            cream.SetPeanuts(this.Peanuts);
            cream.SetCherrys(this.Cherrys);
            return cream;
        }
    }
}
