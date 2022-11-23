using System;

namespace WorkshopHandsOn8.ExceptionChain
{
    public interface IChainLink
    {
        void Process(Exception ex);
    }
}
