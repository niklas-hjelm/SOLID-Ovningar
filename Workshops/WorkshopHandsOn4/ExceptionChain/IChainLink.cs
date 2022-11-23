using System;

namespace WorkshopHandsOn4.ExceptionChain
{
    public interface IChainLink
    {
        void Process(Exception ex);
    }
}
