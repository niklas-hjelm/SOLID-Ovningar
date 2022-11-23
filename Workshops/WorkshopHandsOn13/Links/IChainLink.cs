using System;

namespace WorkshopHandsOn13.Links
{
    public interface IChainLink<T>
    {
        IChainLink<T> SetSuccessor(IChainLink<T> next);
        void Handle(T data);
    }
}
