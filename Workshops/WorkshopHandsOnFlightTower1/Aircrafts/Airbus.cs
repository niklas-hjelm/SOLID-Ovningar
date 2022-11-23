using WorkshopHandsOnFlightTower1.Tower;

namespace WorkshopHandsOnFlightTower1.Aircrafts
{
    class Airbus : Aircraft
    {
        private Airbus(string callSign, ITrafficControlTower tower)
            : base(callSign, tower)
        {
            tower.RegisterAircraftUnderGuidance(this);
        }

        public static IAircraft Create(string callSign, ITrafficControlTower tower)
        {
            return new Airbus(callSign, tower);
        }

        public override int Ceiling
        {
            get { return 10000; }
        }
    }
}
