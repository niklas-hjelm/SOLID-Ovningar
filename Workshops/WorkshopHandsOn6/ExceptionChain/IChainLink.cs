using System;

namespace WorkshopHandsOn6.ExceptionChain
{
    public interface IChainLink
    {
        void Process(Exception ex);
    }
}
