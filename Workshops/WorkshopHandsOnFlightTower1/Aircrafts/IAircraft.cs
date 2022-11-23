namespace WorkshopHandsOnFlightTower1.Aircrafts
{
    interface IAircraft
    {
        int Altitude { get; }
        string CallSign { get; }
        int Ceiling { get; }

        IAircraft SetAltitude(int altitude);
        IAircraft SetClimb(int height);
        void WarnOfAirspaceIntrusionBy(IAircraft reportingAircraft);
    }
}