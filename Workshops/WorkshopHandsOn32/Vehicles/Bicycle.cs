
using System.Drawing;

namespace WorkshopHandsOn32.Vehicles
{
    public class Bicycle : IBicycle
    {
        public int Gears { get; private set; }
        public string TypeOf { get; private set; }
        public Color Color { get; private set; }

        public Bicycle(string typeOfBicycle, int gears, Color color) 
        {
            TypeOf = typeOfBicycle;
            Gears = gears;
            Color = color;
        }
    }
}
