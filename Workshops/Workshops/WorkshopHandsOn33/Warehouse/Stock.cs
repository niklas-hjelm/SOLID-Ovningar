using System;
using System.Collections.Generic;
using WorkshopHandsOn33.LawnMowers;

namespace WorkshopHandsOn33.Warehouse
{
    sealed class Stock : IStock
    {
        private int _saldo = 0;
        private List<ILawnMower> _lawnMowers = new List<ILawnMower>();

        private Stock()
        { }

        public static IStock Create()
        { 
            return new Stock();
        }

        public int Saldo
        {
            get { return this._saldo; }
            private set { this._saldo = value; }
        }

        public void Add(ILawnMower mower)
        {
            _lawnMowers.Add(mower);
            UpdateSaldo();
        }

        public void Add(IList<ILawnMower> mowers)
        {
            foreach (var mower in mowers)
            {
                Add(mower);
            }
        }

        public void Remove(ILawnMower mower)
        {
            if (_lawnMowers.Remove(mower))
                UpdateSaldo();
        }

        public void Remove(IList<ILawnMower> mowers)
        {
            foreach (var mower in mowers)
            {
                Remove(mower);
            }
        }

        public string PrintStock()
        {
           return BuildString(this._lawnMowers, null);
        }

        public string PrintStock(Type type)
        {
            return BuildString(this._lawnMowers.FindAll(m => m.GetType().Equals(type)), type);
        }

        private void UpdateSaldo()
        {
            Saldo = this._lawnMowers.Count;
        }

        private string BuildString(IList<ILawnMower> mowers, Type type)
        {
            string result = type == null ? "Mowers in stock\n" : String.Format("Mowers of type ({0}) in stock\n", type.Name);
            foreach (var mower in mowers)
            {
                result += mower.ToString() + "\n";
            }
            return result;
        }
    }
}
