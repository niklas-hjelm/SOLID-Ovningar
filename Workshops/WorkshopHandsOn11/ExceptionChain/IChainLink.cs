using System;

namespace WorkshopHandsOn11.ExceptionChain
{
    public interface IChainLink
    {
        void Process(Exception ex);
    }
}
