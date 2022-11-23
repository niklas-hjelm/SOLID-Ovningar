using System;
using WorkshopHandsOn11.ValueObjects;

namespace WorkshopHandsOn11.States
{
    class IdleState : State<IRobot>
    {
        public override void Execute(IRobot context)
        {
            context.Reset().SetPowerOn().SetCanWalkOn();
            context.MoveTo(Position.Create(0, 0)).SetPowerOff().SetCanWalkOff();
            this.Logger.Log(string.Format("{0} is idling.", context.Name));
        }
    }
}
