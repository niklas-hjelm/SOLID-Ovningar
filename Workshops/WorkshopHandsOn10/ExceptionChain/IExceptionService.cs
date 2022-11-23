using System;

namespace WorkshopHandsOn10.ExceptionChain
{
    public interface IExceptionService
    {
        void Process(Exception ex);
    }
}
