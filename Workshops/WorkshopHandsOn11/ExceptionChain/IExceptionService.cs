using System;

namespace WorkshopHandsOn11.ExceptionChain
{
    public interface IExceptionService
    {
        void Process(Exception ex);
    }
}
