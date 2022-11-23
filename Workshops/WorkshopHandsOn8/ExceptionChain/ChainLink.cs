using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkshopHandsOn8.ExceptionChain
{
    public abstract class ChainLink : IChainLink
    {
        public IChainLink Successor { get; private set; }

        protected ChainLink(IChainLink successor)
        {
            this.Successor = successor;
        }       
        public abstract void Process(Exception ex);
    }
}
