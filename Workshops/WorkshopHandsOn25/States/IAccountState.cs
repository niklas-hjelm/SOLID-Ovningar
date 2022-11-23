namespace WorkshopHandsOn25
{
    public interface IAccountState
    {
        IAccount Account { get; }
        double Balance { get; }
        bool Deposit(double amount);
        IAccountState SetBalance(double balance);
        bool Withdraw(double amount);
    }
}