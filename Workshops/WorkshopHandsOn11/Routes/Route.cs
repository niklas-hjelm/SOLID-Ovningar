using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace WorkshopHandsOn11.Routes
{
    public class Route<T> : IEnumerable<T>
    {
        public T LastStep { get; private set; }
        public Route<T> PreviousSteps { get; private set; }
        public double TotalCost { get; private set; }

        private Route(T lastStep, Route<T> previousSteps, double totalCost)
        {
            LastStep = lastStep;
            PreviousSteps = previousSteps;
            TotalCost = totalCost;
        }
        public Route(T start) : 
            this(start, null, 0) 
        { 
        }
        public Route<T> AddStep(T step, double stepCost)
        {
            return new Route<T>(step, this, TotalCost + stepCost);
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (var p = this; p != null; p = p.PreviousSteps)
                yield return p.LastStep;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


    }
}
