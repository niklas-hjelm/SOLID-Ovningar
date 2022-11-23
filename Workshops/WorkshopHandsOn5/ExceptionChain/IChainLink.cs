using System;

namespace WorkshopHandsOn5.ExceptionChain
{
    public interface IChainLink
    {
        void Process(Exception ex);
    }
}
