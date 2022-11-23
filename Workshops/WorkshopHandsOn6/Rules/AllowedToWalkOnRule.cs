using System;
using System.Linq;
using WorkshopHandsOn6;

namespace WorkshopHandsOn6.Rules
{
    public class NotAllowedToWalkRule  : Rule<IRobotState>
    {
        public NotAllowedToWalkRule()
            : base(r => r.CanWalk())
        {
            this.SetMessage("Not allowed to walk!");
        }
    }
}
