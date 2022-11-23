using WorkshopHandsOn23.Base;

namespace WorkshopHandsOn23.Decorators
{
    public class SugarDecorator : CondimentDecorator
    {
        public SugarDecorator(IBeverage beverage)
            : base(beverage)
        {
            Description = Beverage.Description + ", Sugar";
            Cost = Beverage.Cost + 1;
        }
        protected override void PourInCup()
        {
            Cup.Fill($"Water and {Description}");
        }
    }
}
