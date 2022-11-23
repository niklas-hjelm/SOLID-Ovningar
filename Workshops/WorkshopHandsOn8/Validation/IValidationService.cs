using System;
using System.Collections.Generic;

namespace WorkshopHandsOn8.Validation
{
    public interface IValidationService<T> where T : IValidatable<T>
    {
        IValidationService<T> AddValidators(IEnumerable<IValidator<T>> validators);
        IValidationService<T> AddValidator(IValidator<T> validator);
        IEnumerable<IValidator<T>> GetValidators(T entity);
        Tuple<Boolean, IEnumerable<string>> Validate(T entity);
    }
}
