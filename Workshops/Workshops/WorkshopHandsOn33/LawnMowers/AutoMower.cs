using System;

namespace WorkshopHandsOn33.LawnMowers
{
    class AutoMower : LawnMower, IAutoMower
    {
        private int _hours = 0;
        private string _starttime = "00:00";

        private AutoMower(string brand) : base(brand, "Electricity")
        { }

        public static IAutoMower Create(string brand) 
        { 
            return new AutoMower(brand);
        }

        public void SetStartTime(string time)
        {
            this._starttime = time;
        }

        public void SetHours(int hours)
        {
            this._hours = hours;
        }

        public void Start()
        {
            this.IsRunning = true;
        }

        public void Stop()
        {
            this.IsRunning = false;
        }

        public override string ToString()
        {
            return string.Format("ArtNr:{0}   Brand:{1, 10}   Type of fuel:{2, 11}   Start:{3, 5}   Active:{4, 5}",
                                    this.ArtNr, this.Brand, this.Fuel, this._starttime, this._hours + "h");
        }
    }
}
