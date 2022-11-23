namespace WorkshopHandsOn26
{
    public abstract class AccountState : IAccountState
    {
        protected virtual double InterestRate { get; set; } = 0;
        protected virtual double LowerLimit { get; set; } = 0;
        protected virtual double UpperLimit { get; set; } = 0;

        public IAccount Account { get; }
        public double Balance { get; protected set; }

        protected AccountState(IAccount account)
        {
            Account = account;
        }

        public IAccountState SetBalance(double balance)
        {
            Balance = balance;
            return this;
        }

        public abstract double? AccrueInterest();
        public abstract bool Deposit(double amount);
        protected abstract void TryStateChange();
        public abstract bool Withdraw(double amount);
    }
}
