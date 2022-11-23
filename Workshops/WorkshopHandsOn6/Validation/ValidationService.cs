using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkshopHandsOn6.Validation
{
    public sealed class ValidationService<T> : IValidationService<T> where T : IValidatable<T>
    {
        private static IList<KeyValuePair<Type, IGenericValidator>> _validators = new List<KeyValuePair<Type, IGenericValidator>>();
 
        private ValidationService()
        {
        }
        public static IValidationService<T> Create()
        {
            return new ValidationService<T>();
        }
        public IValidationService<T> AddValidator(IValidator<T> validator) 
        {
            var v = new KeyValuePair<Type, IGenericValidator>(typeof(T), ((IGenericValidator)validator));
            _validators.Add(v);
             return this;
        }
        public IValidationService<T> AddValidators(IEnumerable<IValidator<T>> validators)
        {
            validators.ToList().ForEach(v => this.AddValidator(v));
             return this;
        }
        public IEnumerable<IValidator<T>> GetValidators(T entity) 
        {
            IEnumerable<KeyValuePair<Type, IGenericValidator>> list = _validators.Where(v => v.Key.UnderlyingSystemType.Equals(typeof(T)));
            IList<IValidator<T>> validators = new List<IValidator<T>>();
            foreach (KeyValuePair<Type, IGenericValidator> kv in list)
            {
                validators.Add((IValidator<T>)kv.Value);
            }
            return validators;
        }
        public Tuple<Boolean, IEnumerable<string>> Validate(T entity)
        {
            IEnumerable<string> broken = new List<string>();
            IEnumerable<IValidator<T>> validators = GetValidators(entity);
            foreach (IValidator<T> v in validators)
            {
                Tuple<Boolean, IEnumerable<string>> result = entity.Validate(v);
                if (!result.Item1)
                    broken = broken.Concat(result.Item2); // Merge errors.
            }
            return Tuple.Create(broken.Count() == 0, broken);
        }
    }
}
