using WorkshopHandsOn14.States;

namespace WorkshopHandsOn14
{
    class TrafficLight : ITrafficLight
    {
        IStateService _service;

        public static ITrafficLight Create(IStateService service)
        {
            return new TrafficLight(service);
        }
        private TrafficLight(IStateService service)
        {
            this._service = service;
        }
        public void Toggle()
        {
            this._service.Execute();
        }
    }
}
