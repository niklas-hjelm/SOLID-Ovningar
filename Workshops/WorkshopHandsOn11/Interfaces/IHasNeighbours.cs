using System;
using System.Collections.Generic;

namespace WorkshopHandsOn11.Interfaces
{
    public interface IHasNeighbours<N>
    {
        IEnumerable<N> Neighbours { get; }
    }
}
