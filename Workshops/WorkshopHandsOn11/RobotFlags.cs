using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkshopHandsOn11
{
    [Flags]
    public enum RobotFlags : int
    {
        None = 0,
        PowerOn,
        CanWalk,
        StelthMode
    }
}
