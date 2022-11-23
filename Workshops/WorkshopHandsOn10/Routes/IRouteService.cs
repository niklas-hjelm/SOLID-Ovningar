using System;
using System.Collections.Generic;
using WorkshopHandsOn10.ValueObjects;

namespace WorkshopHandsOn10.Routes
{
    public interface IRouteService
    {
        IList<Position> GetRoute(Tile start, Tile end);
    }
}
