using System;

namespace WorkshopHandsOn14.States
{
    public class RedLight : State
    {
        public RedLight()
            : base()
        {}

       public override void Execute()
        {
            Console.WriteLine("Red Light On");
        }
        public override void NextState(IStateService service)
        {
            service.SetState(new RedYellowLight());
        }
    }
}