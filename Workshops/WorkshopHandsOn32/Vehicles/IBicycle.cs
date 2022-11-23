using System;

namespace WorkshopHandsOn32.Vehicles
{
    public interface IBicycle : IVehicle
    {
        int Gears { get; }
        string TypeOf { get; }
    }
}
