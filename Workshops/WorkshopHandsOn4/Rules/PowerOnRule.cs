using System;
using System.Linq;
using WorkshopHandsOn4;

namespace WorkshopHandsOn4.Rules
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
