using WorkshopHandsOn24.ValueObjects;

namespace WorkshopHandsOn24.Base
{
    public interface IBeverage
    {
        Cup PrepareDrink();
        string Description { get; }
        double Cost { get; }
    }
}