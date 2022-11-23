using System;
using System.Linq;
using WorkshopHandsOn8;

namespace WorkshopHandsOn8.Rules
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
