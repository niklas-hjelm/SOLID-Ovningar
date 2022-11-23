namespace WorkshopHandsOn26
{
    public class InterestAccountState : AccountState
    {
        protected override double InterestRate { get; set; } = 0.05;
        protected override double LowerLimit { get; set; } = -1500; // Allowed to have some credit.
        protected override double UpperLimit { get; set; } = 500; // Maximum limit for interest.

        public static IAccountState Create(IAccountState accountState)
        {
            return new InterestAccountState(accountState);
        }

        private InterestAccountState(IAccountState accountState)
            : this(accountState.Balance, accountState.Account)
        { }

        private InterestAccountState(double balance, IAccount account)
            : base(account)
        {
            Balance = balance;
        }

        public override bool Deposit(double amount)
        {
            Balance += amount;
            TryStateChange();
            return true;
        }

        public override double? AccrueInterest()
        {
            double accruedInterest = InterestRate * Balance;
            Balance += accruedInterest;
            TryStateChange();
            return accruedInterest;
        }

        protected override void TryStateChange()
        {
            if (Balance < LowerLimit)
            {
                Account.SetAccountState(OverdrawnAccountState.Create(this));
            }
            else if (Balance < UpperLimit)
            {
                Account.SetAccountState(BasicAccountState.Create(this));
            }
        }

        public override bool Withdraw(double amount)
        {
            Balance -= amount;
            TryStateChange();
            return true;
        }
    }
}
