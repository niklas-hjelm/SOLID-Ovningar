using System;

namespace WorkshopHandsOn32.Builders
{
    /// <summary>
    /// Interface for the template class for inplementation of a Builder Pattern. 
    /// </summary>
    /// <typeparam name="TParamContainer">Container with parameters for the builder.</typeparam>
    /// <typeparam name="TResult">Returned type of built instance.</typeparam>
    public interface IBuilder<TParamContainer, TResult>
    {
        TResult Build(TParamContainer container);
    }
}
