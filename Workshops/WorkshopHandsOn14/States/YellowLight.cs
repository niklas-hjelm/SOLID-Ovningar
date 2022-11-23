using System;

namespace WorkshopHandsOn14.States
{
    public class YellowLight : State
    {
        public YellowLight()
            : base()
        { }

        public override void Execute()
        {
            Console.WriteLine("Yellow Light On");
        }
        public override void NextState(IStateService service)
        {
            service.SetState(new RedLight());
        }
    }
}