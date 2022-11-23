using System;

namespace WorkshopHandsOn15.Vehicles
{
    class VolvoV70 : IVehicle
    {
        public static IVehicle Create()
        {
            return new VolvoV70();
        }
        private VolvoV70()
        { }
        public string Make
        {
            get { return "V70"; }
        }
        public string Model
        {
            get { return "BiFuel"; }
        }
        public double Price
        {
            get { return 300000; }
        }
    }
}
