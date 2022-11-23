using System;

namespace WorkshopHandsOn26
{
    public class OverdrawnAccountState : AccountState
    {
        protected override double UpperLimit { get; set; } = 0; // Limit where you can start withdraw again.

        public static IAccountState Create(AccountState accountState)
        {
            return new OverdrawnAccountState(accountState);
        }

        private OverdrawnAccountState(AccountState accountState)
            : base(accountState.Account)
        {
            Balance = accountState.Balance;
        }

        public override bool Deposit(double amount)
        {
            Balance += amount;
            TryStateChange();
            return true;
        }

        public override double? AccrueInterest()
        {
            return null;
        }

        protected override void TryStateChange()
        {
            if (Balance > UpperLimit)
            {
                Account.SetAccountState(BasicAccountState.Create(this));
            }
        }

        public override bool Withdraw(double amount)
        {
            Console.WriteLine($"ALERT: Unable to withdraw {amount} due to lack of funds.");
            Console.WriteLine(Account.ToString());
            Console.WriteLine(String.Empty);
            return false;
        }
    }
}
