using WorkshopHandsOn25.ValueObject;

namespace WorkshopHandsOn25
{
    public interface IAccount
    {
        AccountID Identifier { get; }
        double Balance { get; }
        IAccount Deposit(double amount);
        IAccount SetAccountState(IAccountState state);
        IAccount Withdraw(double amount);
    }
}