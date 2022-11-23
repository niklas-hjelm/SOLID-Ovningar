using System;
using System.Threading.Tasks;

namespace WorkshopHandsOn10.Messages
{
    public class Publisher<T> : IPublisher<T>
    {
        private Action<T> _action = null;

        public Publisher()
        {
        }
        public void Publish(T e)
        {
            if (this._action != null)
            {
                this._action.Invoke(e);
            };
        }
        public void Register(Action<T> action)
        {
            this._action = (Action<T>)Delegate.Combine(this._action, action);
        }
        public void UnRegister(Action<T> action)
        {
            this._action = (Action<T>)Delegate.Remove(this._action, action);
        }
        public void RemoveAll()
        {
            if (this._action != null)
            {
                Delegate[] tmp = this._action.GetInvocationList();
                this._action = (Action<T>)Delegate.RemoveAll(this._action, tmp[0]);
            };
        }
    }
}