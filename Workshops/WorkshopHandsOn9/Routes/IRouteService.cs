using System;
using System.Collections.Generic;
using WorkshopHandsOn9.ValueObjects;

namespace WorkshopHandsOn9.Routes
{
    public interface IRouteService
    {
        IList<Position> GetRoute(Tile start, Tile end);
    }
}
