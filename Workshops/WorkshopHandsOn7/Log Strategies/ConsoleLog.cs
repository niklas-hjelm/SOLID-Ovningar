using System;
using System.Collections.Generic;
using System.Linq;

namespace WorkshopHandsOn7.Log_Strategies
{
    class ConsoleLog : LogStrategy
    {
        public void PrintSorted(IList<IRobot> robots)
        {
            IDictionary<string, IRobot> sortedRobots = new SortedList<string, IRobot>();
            foreach (IRobot r in robots)
            {
                sortedRobots.Add(r.CurrentPosition().ToString(), r);
            }
            foreach (KeyValuePair<string, IRobot> kv in sortedRobots)
            {
                Log(string.Format("Position {0} has {1}.", kv.Key, kv.Value.Name));
            }
        }
        public override void Log(string message)
        {
            Console.WriteLine(string.Format("Debug logged: {0}", message));
        }
    }
}
