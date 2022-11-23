using System;
using System.Collections.Generic;
using System.Linq;
using WorkshopHandsOnFlightTower1.Aircrafts;

namespace WorkshopHandsOnFlightTower1.Tower
{
    class TrafficControlTower : ITrafficControlTower
    {
        private IDictionary<string, IAircraft> _aircraftUnderGuidance = new Dictionary<string, IAircraft>();

        public static ITrafficControlTower Create()
        {
            return new TrafficControlTower();
        }

        private TrafficControlTower()
        {}

        public void ReceiveAircraftLocation(IAircraft notifying)
        {
            foreach (IAircraft current in _aircraftUnderGuidance.Values.Where(a => !a.CallSign.Equals(notifying.CallSign)))
            {
                // If reporting plane's altitude is closer than 1000m from current plane => climb reporting plane with 1000m
                if (Math.Abs(current.Altitude - notifying.Altitude) < 1000)
                {
                    current.WarnOfAirspaceIntrusionBy(notifying);

                    if (notifying.Altitude + 1000 <= notifying.Ceiling)
                    {
                        Console.WriteLine($"Tower order {notifying.CallSign} to climb 1000 meters.");
                        notifying.SetClimb(1000);
                    }
                    else
                    {
                        Console.WriteLine($"Tower order {notifying.CallSign} to decent 100 meters.");
                        notifying.SetClimb(-100);
                    }
                }
            }
        }

        public void RegisterAircraftUnderGuidance(IAircraft aircraft)
        {
            if (!_aircraftUnderGuidance.ContainsKey(aircraft.CallSign))
            {
                _aircraftUnderGuidance.Add(aircraft.CallSign, aircraft);
            }
        }
    }
}
