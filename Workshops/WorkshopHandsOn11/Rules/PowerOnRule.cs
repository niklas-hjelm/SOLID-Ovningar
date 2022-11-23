using System;
using System.Linq;
using WorkshopHandsOn11;

namespace WorkshopHandsOn11.Rules
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
