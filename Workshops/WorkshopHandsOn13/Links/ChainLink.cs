namespace WorkshopHandsOn13.Links
{
    abstract class ChainLink<T> : IChainLink<T>
    {
        private IChainLink<T> _next;

        public IChainLink<T> SetSuccessor(IChainLink<T> next)
        {
            this._next = next;
            return this;
        }
        protected void TrySuccessor(T data)
        {
            if (this._next != null)
                this._next.Handle(data);
        }
        abstract public void Handle(T data);
        abstract protected bool CanHandle(T data);
    }
}
