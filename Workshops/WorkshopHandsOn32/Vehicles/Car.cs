using System.Drawing;

namespace WorkshopHandsOn32.Vehicles
{
    public class Car : ICar
    {
        public Color Color { get; private set; }
        public string TypeOf { get; private set; }
        public string DriveChain { get; private set; }

        public Car(string typeOfCar, Color color, string driveChain)
        {
            TypeOf = typeOfCar;
            Color = color;
            DriveChain = driveChain;    
        }
    }
}
