using System;

namespace WorkshopHandsOn9.ExceptionChain
{
    public interface IExceptionService
    {
        void Process(Exception ex);
    }
}
