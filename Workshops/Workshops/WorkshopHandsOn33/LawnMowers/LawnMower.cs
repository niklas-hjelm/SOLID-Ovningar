using System;

namespace WorkshopHandsOn33.LawnMowers
{
    abstract class LawnMower : ILawnMower
    {
        public Guid ArtNr { get; private set; }
        protected string Brand { get; set; }
        protected string Fuel { get; set; }
        protected bool IsRunning { get; set; }

        public LawnMower(string brand, string fuel)
        {
            ArtNr = Guid.NewGuid();
            Brand = brand;
            Fuel = fuel;
            IsRunning = false;
        }

        public string Mowing()
        {
            return string.Format("Brand:{1, 10} is mowing:{2, 5}", this.Brand, this.IsRunning);
        }
    }
}
