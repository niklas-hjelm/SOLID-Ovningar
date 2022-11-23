using System;

namespace WorkshopHandsOn6.ExceptionChain
{
    public interface IExceptionService
    {
        void Process(Exception ex);
    }
}
