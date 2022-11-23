using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkshopHandsOn6
{
    [Flags]
    public enum RobotFlags : int
    {
        None = 0,
        PowerOn = 1,
        CanWalk = 2
    }
}
