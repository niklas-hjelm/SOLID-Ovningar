using System.Collections.Generic;
using System;

namespace WorkshopHandsOn5.Validation
{
    public interface IValidatable<T>
    {
        Tuple<Boolean, IEnumerable<string>> Validate(IValidator<T> validator);
    }
}