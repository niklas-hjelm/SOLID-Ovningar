using WorkshopHandsOn23.ValueObjects;

namespace WorkshopHandsOn23.Base
{
    public interface IBeverage
    {
        Cup PrepareDrink();
        string Description { get; }
        double Cost { get; }
    }
}