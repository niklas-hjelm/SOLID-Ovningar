using WorkshopHandsOn23.Base;

namespace WorkshopHandsOn23.Decorators
{
    public class WhipDecorator : CondimentDecorator
    {
        public WhipDecorator(IBeverage beverage)
            : base(beverage)
        {
            Description = Beverage.Description + ", Whip";
            Cost = Beverage.Cost + 5;
        }

        protected override void PourInCup()
        {
            Cup.Fill($"Water and {Description}");
        }
    }
}
