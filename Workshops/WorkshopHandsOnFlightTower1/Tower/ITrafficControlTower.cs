using WorkshopHandsOnFlightTower1.Aircrafts;

namespace WorkshopHandsOnFlightTower1.Tower
{
    interface ITrafficControlTower
    {
        void ReceiveAircraftLocation(IAircraft notifying);
        void RegisterAircraftUnderGuidance(IAircraft aircraft);
    }
}