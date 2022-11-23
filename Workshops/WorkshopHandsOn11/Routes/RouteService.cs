using System;
using System.Linq;
using System.Collections.Generic;
using WorkshopHandsOn11.ValueObjects;

namespace WorkshopHandsOn11.Routes
{
    public class RouteService : IRouteService
    {
         public static IRouteService Create()
        {
            return new RouteService();
        }
         private RouteService()
        {
        }
        public IList<Position> GetRoute(Tile start, Tile end)
        {
            IList<Position> positions = new List<Position>();

            Func<Tile, Tile, double> distance = (node1, node2) => 1;
            Func<Tile, double> estimation = n => Math.Abs(n.X - end.X) + Math.Abs(n.Y - end.Y);

            RouteFinder f = RouteFinder.Create();
            var path = f.FindRoute(start, end, distance, estimation);
            if (path != null)
            {
                foreach (Tile t in path)
                {
                    positions.Insert(0, Position.Create(t.X + 1, t.Y + 1));
                }
            }
            return positions;
        }
     }
}
