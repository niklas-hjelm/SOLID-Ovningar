using System;
using System.Linq;
using WorkshopHandsOn8;

namespace WorkshopHandsOn8.Rules
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
