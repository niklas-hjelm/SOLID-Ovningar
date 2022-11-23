using System.Collections.Generic;

namespace WorkshopHandsOn3.Validation
{
    public interface IValidator<T> : IGenericValidator
    {
         bool IsValid(T entity);
        IEnumerable<string> BrokenRules(T entity);
    }
}