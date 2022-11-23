using System;
using System.Collections.Generic;
using WorkshopHandsOn11.ValueObjects;

namespace WorkshopHandsOn11.Routes
{
    public interface IRouteService
    {
        IList<Position> GetRoute(Tile start, Tile end);
    }
}
