using WorkshopHandsOn26.ValueObject;

namespace WorkshopHandsOn26
{
    public interface IAccount
    {
        AccountID Identifier { get; }
        double? AccrueInterest();
        double Balance { get; }
        IAccount Deposit(double amount);
        IAccount SetAccountState(IAccountState state);
        IAccount Withdraw(double amount);
    }
}