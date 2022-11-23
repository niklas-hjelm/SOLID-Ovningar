using System;

namespace WorkshopHandsOn33.LawnMowers
{
    internal interface ILawnMower
    {
        Guid ArtNr { get; }

        string Mowing();
    }
}