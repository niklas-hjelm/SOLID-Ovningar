using System;
using System.Linq;
using WorkshopHandsOn3;

namespace WorkshopHandsOn3.Rules
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
