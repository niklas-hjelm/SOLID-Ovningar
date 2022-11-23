using System;
using System.Linq;
using WorkshopHandsOn7;

namespace WorkshopHandsOn7.Rules
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
