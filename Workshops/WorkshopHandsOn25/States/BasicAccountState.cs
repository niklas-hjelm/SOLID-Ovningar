namespace WorkshopHandsOn25
{
    public class BasicAccountState : AccountState
    {
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

        protected override void TryStateChange()
        {
            if (Balance < LowerLimit)
            {
                Account.SetAccountState(OverdrawnAccountState.Create(this));
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
