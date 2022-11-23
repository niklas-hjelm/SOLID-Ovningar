using System;
using System.Linq;
using WorkshopHandsOn9;

namespace WorkshopHandsOn9.Rules
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
