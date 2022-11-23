using System;

namespace WorkshopHandsOn7.ExceptionChain
{
    public interface IChainLink
    {
        void Process(Exception ex);
    }
}
