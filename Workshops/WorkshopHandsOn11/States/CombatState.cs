using System;
using WorkshopHandsOn11.ValueObjects;

namespace WorkshopHandsOn11.States
{
    class CombatState : State<IRobot>
    {
        public override void Execute(IRobot context)
        {
            context.Reset().SetPowerOn().SetCanWalkOn();
            context.MoveTo(Position.Create(0, 0)).SetPowerOff().SetCanWalkOff().SetStelthModeOn();
            context.Grab(this.GrabRocketLauncher);
            this.Logger.Log(string.Format("{0} is armed.", context.Name));
        }
        private string GrabRocketLauncher(IRobot robot)
        {
            return string.Format("{0} grabbed the rocketlauncher.", robot.Name);
        }
    }
}
