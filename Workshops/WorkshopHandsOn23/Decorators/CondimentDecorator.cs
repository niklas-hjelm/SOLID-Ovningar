using WorkshopHandsOn23.Base;

namespace WorkshopHandsOn23.Decorators
{
    public abstract class CondimentDecorator : Beverage
    {
        protected IBeverage Beverage { get; private set; }

        public CondimentDecorator(IBeverage beverage)
        {
            Beverage = beverage;
        }
    }
}
