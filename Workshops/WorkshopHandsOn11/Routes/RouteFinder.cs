using System;
using System.Collections.Generic;
using System.Linq;
using WorkshopHandsOn11.Interfaces;
using WorkshopHandsOn11.Common;

namespace WorkshopHandsOn11.Routes
{
    public class RouteFinder : IRouteFinder
    {
        public static RouteFinder Create()
        {
            return new RouteFinder();
        }
        private RouteFinder()
        {
        }      
        public Route<T> FindRoute<T>(T start, T destination, Func<T, T, double> distance, Func<T, double> estimate) where T : IHasNeighbours<T>
        {
            var closed = new HashSet<T>();
            var queue = new PriorityQueue<double, Route<T>>();
            queue.Enqueue(0, new Route<T>(start));

            while (!queue.IsEmpty)
            {
                var path = queue.Dequeue();

                if (closed.Contains(path.LastStep))
                    continue;
                if (path.LastStep.Equals(destination))
                    return path;

                closed.Add(path.LastStep);

                foreach (T n in path.LastStep.Neighbours)
                {
                    double d = distance(path.LastStep, n);
                    var newPath = path.AddStep(n, d);
                    queue.Enqueue(newPath.TotalCost + estimate(n), newPath);
                }
            }
            return null;
        }
    }
}
