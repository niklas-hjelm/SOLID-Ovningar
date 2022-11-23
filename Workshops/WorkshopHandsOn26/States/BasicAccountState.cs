namespace WorkshopHandsOn26
{
    public class BasicAccountState : AccountState
    {
        protected override double InterestRate { get; set; } = 0; // No interest as default.
        protected override double UpperLimit { get; set; } = 500; // Limit for interest, above will give you interest.
        protected override double LowerLimit { get; set; } = -1500; // Allowed to have some credit.

        public static IAccountState Create(IAccountState accountState)
        {
            return new BasicAccountState(accountState);
        }

        public static IAccountState Create(double balance, IAccount account)
        {
            return new BasicAccountState(balance, account);
        }

        private BasicAccountState(IAccountState accountState) :
            this(accountState.Balance, accountState.Account)
        { }

        private BasicAccountState(double balance, IAccount account)
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
            return null;
        }

        protected override void TryStateChange()
        {
            if (Balance < LowerLimit)
            {
                Account.SetAccountState(OverdrawnAccountState.Create(this));
            }
            else if (Balance > UpperLimit)
            {
                Account.SetAccountState(InterestAccountState.Create(this));
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
