using System;
using System.Collections.Generic;
using WorkshopHandsOn33.LawnMowers;

namespace WorkshopHandsOn33.Warehouse
{
    internal interface IStock
    {
        int Saldo { get; }

        void Add(ILawnMower mower);
        void Add(IList<ILawnMower> mowers);
        void Remove(ILawnMower mower);
        void Remove(IList<ILawnMower> mowers);
        string PrintStock(Type type);
        string PrintStock();
    }
}