using System;

namespace WorkshopHandsOn4.ExceptionChain
{
    public interface IExceptionService
    {
        void Process(Exception ex);
    }
}
