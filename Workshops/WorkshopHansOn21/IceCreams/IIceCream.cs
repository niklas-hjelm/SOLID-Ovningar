namespace WorkshopHandsOn21.IceCreams
{
    interface IIceCream
    {
        IceCreamTypes Type { get; }
        FlavorTypes Flavor { get; }
        int Peanuts { get; }
        int Cherrys { get; }
        int Caramels { get; }

        void SetCaramels(int spoon);
        void SetCherrys(int number);
        void SetFlavor(FlavorTypes flavor);
        void SetType(IceCreamTypes type);
        void SetPeanuts(int spoon);
        void Reset();
        IIceCream Copy();
    }
}