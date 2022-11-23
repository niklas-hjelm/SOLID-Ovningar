using System;

namespace WorkshopHandsOn14.States
{
    public class RedYellowLight : State
    {
        public RedYellowLight()
            : base()
        { }

        public override void Execute()
        {
            Console.WriteLine("Red/Yellow Light On");
        }
        public override void NextState(IStateService service)
        {
            service.SetState(new GreenLight());
        }
    }
}