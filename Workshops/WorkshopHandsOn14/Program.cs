using System;

namespace WorkshopHandsOn14.States
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IStateService service = StateService.Create().SetState(new RedLight());
            ITrafficLight light = TrafficLight.Create(service);

            // Execute current state and go to next state
            light.Toggle(); // -- Red Light
            light.Toggle(); // -- Red/Yellow Light
            light.Toggle(); // -- Green Light
            light.Toggle(); // -- Yellow Light
            light.Toggle(); // -- Red Light

            Console.ReadKey();
        }
    }
}