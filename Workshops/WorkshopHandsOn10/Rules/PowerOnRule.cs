using System;
using System.Linq;
using WorkshopHandsOn10;

namespace WorkshopHandsOn10.Rules
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
