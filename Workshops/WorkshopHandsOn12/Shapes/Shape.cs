using System;
using System.Drawing;

namespace WorkshopHandsOn12.Shapes
{
    public abstract class Shape : IShape
    {
        protected Color _color = Color.White;

        public Color Color {
            get { return _color; }
            set { _color = value; } }

        public Shape()
        {
        }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract IShape Draw();
    }
}
