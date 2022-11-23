using System;
using WorkshopHandsOnFlightTower1.Tower;

namespace WorkshopHandsOnFlightTower1.Aircrafts
{
    abstract class Aircraft : IAircraft
    {
        protected ITrafficControlTower Tower { get; private set; }

        protected Aircraft(string callSign, ITrafficControlTower tower)
        {
            Tower = tower;
            CallSign = callSign;
            Tower.RegisterAircraftUnderGuidance(this);
        }

        public abstract int Ceiling { get; }
        public string CallSign { get; private set; }
        public int Altitude { get; private set; }

        public IAircraft SetAltitude(int altitude)
        {
            Altitude = altitude;
            Tower.ReceiveAircraftLocation(this);
            return this;
        }

        public IAircraft SetClimb(int height)
        {
            int temp = Altitude + height;
            if (temp >= this.Ceiling)
            {
                SetAltitude(this.Ceiling);
                Console.WriteLine($"{CallSign} is climbing to maximum altitude: {Altitude} meters.");
            }
            else if (temp > 0)
            {
                string action = temp > Altitude ? "climbing" : "decending";
                Console.WriteLine($"{CallSign} is {action} to {temp} meters.");
                SetAltitude(temp);
            }
            else if (temp <= 0)
            {
                Console.WriteLine($"{CallSign} will crash! Altitude set to {temp} meters.");
            }
            return this;
        }

        public void WarnOfAirspaceIntrusionBy(IAircraft reportingAircraft)
        {
            Console.WriteLine($"{CallSign} is getting warning that my airspace is compromized by {reportingAircraft.CallSign}.");
        }
    }
}
