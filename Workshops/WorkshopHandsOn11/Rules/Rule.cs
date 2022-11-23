using System;
using System.Linq.Expressions;

namespace WorkshopHandsOn11.Rules
{
    public abstract class Rule<T> : IRule<T>
    {
        public string Message { get; private set; }
        public Expression<Func<T, bool>> Condition { get; private set; }

        public Rule(Expression<Func<T, bool>> condition)
        {
            this.SetCondition(condition);
        }
       public IRule<T> SetMessage(string message)
        {
            this.Message = message;
            return this;
        }
        public IRule<T> SetCondition(Expression<Func<T, bool>> condition)
        {
            this.Condition = condition;
            return this;
        }
    }
}
