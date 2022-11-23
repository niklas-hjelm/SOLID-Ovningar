using System;
using System.Drawing;

namespace WorkshopHandsOn12.Shapes
{
    public class Circle : Shape
    {
        public Circle()
        {
        }

        public Circle(Color color) : base(color)
        {
        }

        public override IShape Draw()
        {
            Console.WriteLine(string.Format("Drawing a Circle with Color = {0}", this.Color.ToString()));
            return this;
        }
    }
}
