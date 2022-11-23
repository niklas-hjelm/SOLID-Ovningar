using System;

namespace WorkshopHandsOn9.ExceptionChain
{
    public interface IChainLink
    {
        void Process(Exception ex);
    }
}
