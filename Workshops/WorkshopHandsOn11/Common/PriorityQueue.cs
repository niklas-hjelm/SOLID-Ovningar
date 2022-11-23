using System;
using System.Collections.Generic;
using System.Linq;

namespace WorkshopHandsOn11.Common
{
    public class PriorityQueue<TPriority, TValue>
    {
        private readonly SortedDictionary<TPriority, Queue<TValue>> _list = new SortedDictionary<TPriority, Queue<TValue>>();

        public void Enqueue(TPriority priority, TValue value)
        {
            Queue<TValue> outQueue;
            if (!_list.TryGetValue(priority, out outQueue))
            {
                outQueue = new Queue<TValue>();
                _list.Add(priority, outQueue);
            }
            outQueue.Enqueue(value);
        }
        public TValue Dequeue()
        {
            KeyValuePair<TPriority, Queue<TValue>> pair = _list.FirstOrDefault();
            TValue value = pair.Value.Dequeue();
            if (pair.Value.Count == 0) 
                _list.Remove(pair.Key);

            return value;
        }
        public bool IsEmpty
        {
            get { return !_list.Any(); }
        }
    }
}
