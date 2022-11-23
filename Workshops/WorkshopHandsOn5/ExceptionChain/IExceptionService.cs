using System;

namespace WorkshopHandsOn5.ExceptionChain
{
    public interface IExceptionService
    {
        void Process(Exception ex);
    }
}
