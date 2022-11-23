using System;
using WorkshopHandsOn9.Interfaces;

namespace WorkshopHandsOn9.Routes
{
    public interface IRouteFinder
    {
        Route<T> FindRoute<T>(T start, T destination, Func<T, T, double> distance, Func<T, double> estimate) where T : IHasNeighbours<T>;
    }
}
