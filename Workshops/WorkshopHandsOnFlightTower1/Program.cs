using System;
using WorkshopHandsOnFlightTower1.Aircrafts;
using WorkshopHandsOnFlightTower1.Tower;

namespace WorkshopHandsOnFlightTower1
{
    class Program
    {
        static void Main(string[] args)
        {
            ITrafficControlTower tower = TrafficControlTower.Create();

            IAircraft flight1 = Airbus.Create("AC159", tower).SetAltitude(10000);
            IAircraft flight2 = Boeing.Create("WS203", tower).SetAltitude(9000);
            IAircraft flight3 = Piper.Create("AC602", tower).SetAltitude(20000);

            flight1.SetClimb(2000);
            flight2.SetClimb(1010);
            
            flight1.SetClimb(-500);
            flight2.SetClimb(-6050);
            flight3.SetClimb(-665550);

            Console.ReadKey();
        }
    }
}
