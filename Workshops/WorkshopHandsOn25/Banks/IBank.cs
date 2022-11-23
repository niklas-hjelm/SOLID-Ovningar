namespace WorkshopHandsOn25.Banks
{
    public interface IBank
    {
        IBank Deposit(string accountId, double amount);
        IBank Withdraw(string accountId, double amount);
        IBank OpenAccount(IAccount account);
    }
}