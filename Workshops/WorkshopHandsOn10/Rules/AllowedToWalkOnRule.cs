using System;
using System.Linq;
using WorkshopHandsOn10;

namespace WorkshopHandsOn10.Rules
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
