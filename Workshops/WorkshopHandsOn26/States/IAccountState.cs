namespace WorkshopHandsOn26
{
    public interface IAccountState
    {
        IAccount Account { get; }
        double Balance { get; }
        double? AccrueInterest();
        bool Deposit(double amount);
        IAccountState SetBalance(double balance);
        bool Withdraw(double amount);
    }
}