using WorkshopHandsOn23.Base;

namespace WorkshopHandsOn23.Decorators
{
    public class MilkDecorator : CondimentDecorator
    {
        public MilkDecorator(IBeverage beverage)
            : base(beverage)
        {
            Description = Beverage.Description + ", Milk";
            Cost = Beverage.Cost + 2;
        }
     
        protected override void PourInCup()
        {
            Cup.Fill($"Water and {Description}");
        }
    }
}
