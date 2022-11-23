using System;

namespace WorkshopHandsOn10.ExceptionChain
{
    public interface IChainLink
    {
        void Process(Exception ex);
    }
}
