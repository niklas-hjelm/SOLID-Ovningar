using System;
using System.Collections.Generic;

namespace WorkshopHandsOn26.Banks
{
    public abstract class Bank : IBank
    {
        protected IDictionary<string, IAccount> Accounts { get; } = new Dictionary<string, IAccount>();

        protected Bank(IAccount account)
        {
            Accounts.Add(account.Identifier.Id, account);
        }

        public IBank Deposit(string accountId, double amount)
        {
            if (Accounts.TryGetValue(accountId, out IAccount account))
            {
                account.Deposit(amount);
                account.AccrueInterest();
                return this;
            }
            Console.WriteLine($"No account found with Id: {accountId}.");
            Console.WriteLine(String.Empty);
            return this;
        }

        public IBank Withdraw(string accountId, double amount)
        {
            if (Accounts.TryGetValue(accountId, out IAccount account))
            {
                account.Withdraw(amount);
                return this;
            }
            Console.WriteLine($"No account found with Id: {accountId}.");
            Console.WriteLine(String.Empty);
            return this;
        }

        public IBank OpenAccount(IAccount account)
        {
            Accounts.Add(account.Identifier.Id, account);
            return this;
        }
    }
}
