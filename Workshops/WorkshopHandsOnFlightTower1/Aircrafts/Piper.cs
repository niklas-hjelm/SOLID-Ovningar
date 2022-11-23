using WorkshopHandsOnFlightTower1.Tower;

namespace WorkshopHandsOnFlightTower1.Aircrafts
{
    class Piper : Aircraft
    {
        private Piper(string callSign, ITrafficControlTower tower)
            : base(callSign, tower)
        {
            tower.RegisterAircraftUnderGuidance(this);
        }

        public static IAircraft Create(string callSign, ITrafficControlTower tower)
        {
            return new Piper(callSign, tower);
        }

        public override int Ceiling
        {
            get { return 3000; }
        }
    }
}
