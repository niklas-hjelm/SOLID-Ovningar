using System;

namespace WorkshopHandsOn25.ValueObject
{
    public sealed class AccountID
    {
        public string Id { get; }
        public SocialSecurityNumber Owner { get; }

        public static AccountID Create(SocialSecurityNumber owner)
        {
            return new AccountID(owner);
        }

        private AccountID(SocialSecurityNumber owner)
        {
            Owner = owner;
            Id = Guid.NewGuid().ToString();
        }
    }
}
