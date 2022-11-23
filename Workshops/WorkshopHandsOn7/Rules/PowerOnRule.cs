using System;
using System.Linq;
using WorkshopHandsOn7;

namespace WorkshopHandsOn7.Rules
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
