using System;

namespace WorkshopHandsOn7.ExceptionChain
{
    public interface IExceptionService
    {
        void Process(Exception ex);
    }
}
