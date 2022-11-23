using System;
using System.Linq;
using WorkshopHandsOn5;

namespace WorkshopHandsOn5.Rules
{
    public class PowerOnRule : Rule<IRobotState>
    {
        public PowerOnRule()
            : base(r => r.IsPowerOn())
        {
            this.SetMessage("Power is not On!");
        }
    }
}
