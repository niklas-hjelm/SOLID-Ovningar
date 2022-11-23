using WorkshopHandsOn15.Vehicles;

namespace WorkshopHandsOn15.Decorators
{
    abstract class VehicleDecorator : IVehicle
    {
        private IVehicle _vehicle;

        public VehicleDecorator(IVehicle vehicle)
        {
            this._vehicle = vehicle;
        }
        public virtual string Make
        {
            get { return this._vehicle.Make; }
        }
        public virtual string Model
        {
            get { return this._vehicle.Model; }
        }
        public virtual double Price
        {
            get { return this._vehicle.Price; }
        }
    }
}
