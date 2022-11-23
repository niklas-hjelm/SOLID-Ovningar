using WorkshopHandsOnFlightTower1.Tower;

namespace WorkshopHandsOnFlightTower1.Aircrafts
{
    class Boeing : Aircraft
    {
        private Boeing(string callSign, ITrafficControlTower tower)
            : base(callSign, tower)
        {
            tower.RegisterAircraftUnderGuidance(this);
        }

        public static IAircraft Create(string callSign, ITrafficControlTower tower)
        {
            return new Boeing(callSign, tower);
        }

        public override int Ceiling
        {
            get { return 12000; }
        }
    }
}
