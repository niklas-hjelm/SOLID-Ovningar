using System;

namespace WorkshopHandsOn14.States
{
    public class GreenLight : State
    {
        public GreenLight()
            : base()
        { }

        public override void Execute()
        {
            Console.WriteLine("Green Light On");
        }
        public override void NextState(IStateService service)
        {
            service.SetState(new YellowLight());
        }
    }
}