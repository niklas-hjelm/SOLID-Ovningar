using System;

namespace WorkshopHandsOn33.LawnMowers
{
    class RidingLawnMower : LawnMower, IRidingLawnMower
    {
        private bool _springseat = false;

        private RidingLawnMower(string brand, bool springseat) : base(brand, "Petrol")
        {
            this._springseat = springseat;
        }

        public static IRidingLawnMower Create(string brand, bool springseat) 
        {
            return new RidingLawnMower(brand, springseat);
        }

        public override string ToString()
        {
            return string.Format("ArtNr:{0}   Brand:{1, 10}   Type of fuel:{2, 11}   Has spring seat:{3, 4}",
                                    this.ArtNr, this.Brand, this.Fuel, this._springseat);
        }
    }
}
