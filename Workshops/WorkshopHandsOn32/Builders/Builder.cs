using System;

namespace WorkshopHandsOn32.Builders
{
    /// <summary>
    /// A template class for inplementation of a Builder Pattern. 
    /// </summary>
    /// <typeparam name="TParamContainer">Container with parameters for the builder.</typeparam>
    /// <typeparam name="TResult">Returned type of built instance.</typeparam>
    public abstract class Builder<TParamContainer, TResult> : IBuilder<TParamContainer, TResult>
    {
        protected TParamContainer _container;

        protected Builder(TParamContainer container)
        {
            _container = container;
        }

        public abstract TResult Build(TParamContainer container);
    }
}
