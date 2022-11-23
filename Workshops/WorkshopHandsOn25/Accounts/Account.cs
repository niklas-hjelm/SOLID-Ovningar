using System;
using WorkshopHandsOn25.ValueObject;

namespace WorkshopHandsOn25
{
    public class Account : IAccount
    {
        private IAccountState AccountState { get; set; }
        public double Balance => AccountState.Balance;
        public AccountID Identifier { get; private set; }

        public static IAccount Create(SocialSecurityNumber owner)
        {
            return new Account(owner);
        }

        private Account(SocialSecurityNumber owner)
        {
            Identifier = AccountID.Create(owner);
            AccountState = BasicAccountState.Create(0, this);
        }

        public IAccount SetAccountState(IAccountState state)
        {
            AccountState = state;
            return this;
        }

        public IAccount Deposit(double amount)
        {
            if (AccountState.Deposit(amount))
            {
                Log($"{Identifier.Owner.NameOfPerson} deposited amount: {amount}");
            }
            return this;
        }

        public IAccount Withdraw(double amount)
        {
            if (AccountState.Withdraw(amount))
            {
                Log($"{Identifier.Owner.NameOfPerson} withdrew: {amount}.");
            }
            return this;
        }

        public override string ToString()
        {
            string output = $"{"ACCOUNT OWNER",-25}{"BALANCE",-25}STATE\n";
            return $"{output}{Identifier.Owner.NameOfPerson,-25}{Balance,-25}{AccountState.GetType().Name}\n";
        }

        private void Log(string input)
        {
            Console.WriteLine(input);
            Console.WriteLine(ToString());
            Console.WriteLine(String.Empty);
        }
    }
}
