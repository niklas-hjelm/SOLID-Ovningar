using System;
using WorkshopHandsOn10.Interfaces;

namespace WorkshopHandsOn10.Routes
{
    public interface IRouteFinder
    {
        Route<T> FindRoute<T>(T start, T destination, Func<T, T, double> distance, Func<T, double> estimate) where T : IHasNeighbours<T>;
    }
}
