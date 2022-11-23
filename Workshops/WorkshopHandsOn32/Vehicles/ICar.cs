using System.Drawing;

namespace WorkshopHandsOn32.Vehicles
{
    public interface ICar : IVehicle
    {
        string TypeOf { get; }
        string DriveChain { get; }
    }
}
