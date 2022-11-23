using System;
using System.Drawing;

namespace WorkshopHandsOn12.Shapes
{
    public class Square : Shape
    {
        public Square()
        {
        }

        public Square(Color color) : base(color)
        {
        }

        public override IShape Draw()
        {
            Console.WriteLine(string.Format("Drawing a Square with Color = {0}", this.Color.ToString()));
            return this;
        }
    }
}
