using System;
namespace WorkshopHandsOn15.Vehicles
{
    public interface IVehicle
    {
        string Make { get; }
        string Model { get; }
        double Price { get; }
    }
}
