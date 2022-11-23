using System;
using System.Collections.Generic;
using WorkshopHandsOn11.ValueObjects;

namespace WorkshopHandsOn11.States
{
    class NormalState : State<IRobot>
    {
        public override void Execute(IRobot context)
        {
            context.Reset().SetPowerOn().SetCanWalkOn();
            context.Grab(this.GrabBroom);
            this.Logger.Log(string.Format("{0} is cleaning.", context.Name));
        }
        private string GrabBroom(IRobot robot)
        {
            return string.Format("{0} grabbed the broom and starting to clean the floor.", robot.Name);
        }
    }
}
