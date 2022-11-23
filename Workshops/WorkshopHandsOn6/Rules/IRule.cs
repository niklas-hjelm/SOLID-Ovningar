using System;
using System.Linq.Expressions;

namespace WorkshopHandsOn6.Rules
{
    public interface IRule<T>
    {
        string Message { get; }
        IRule<T> SetMessage(string message);
        Expression<Func<T, bool>> Condition { get; }
        IRule<T> SetCondition(Expression<Func<T, bool>> condition);
    }
}
