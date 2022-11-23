using System;

namespace WorkshopHandsOn8.ExceptionChain
{
    public interface IExceptionService
    {
        void Process(Exception ex);
    }
}
