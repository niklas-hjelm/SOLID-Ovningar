using System;
using System.Collections.Generic;

namespace WorkshopHandsOn10.Interfaces
{
    public interface IHasNeighbours<N>
    {
        IEnumerable<N> Neighbours { get; }
    }
}
