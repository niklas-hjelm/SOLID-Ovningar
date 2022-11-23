using System;
using System.Drawing;
using WorkshopHandsOn12.Shapes;

namespace WorkshopHandsOn12
{
    public static class ShapeProgram
    {
        public static void Run()
        {
            Console.WriteLine("EXECUTING Shapes.");

            IShape circle = new Circle(Color.Yellow);
            circle.Draw();

            IShape square = new Square();
            square.Draw();

            IShape shape = new Circle(Color.AliceBlue);
            shape.Draw();

            shape = new Square(Color.Cyan);
            shape.Draw();

        }
    }
}
