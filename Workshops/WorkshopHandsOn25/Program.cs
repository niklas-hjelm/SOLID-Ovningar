using System;
using WorkshopHandsOn25.Banks;
using WorkshopHandsOn25.ValueObject;

namespace WorkshopHandsOn25
{
    class Program
    {
        static void Main(string[] args)
        {
            SocialSecurityNumber owner = SocialSecurityNumber.Create(19550925999, "Bernt Johansson");
            IAccount account = Account.Create(owner);
            IBank bank = SwedBank.Create(account);

            bank.Deposit(account.Identifier.Id, 450)
                .Deposit(account.Identifier.Id, 500);

            bank.Withdraw(account.Identifier.Id, 2500)
                .Withdraw(account.Identifier.Id, 1500);

            IAccount secondAccount = Account.Create(owner);
            bank.OpenAccount(secondAccount);
            bank.Deposit(secondAccount.Identifier.Id, 450);

            Console.ReadKey();
        }
    }
}
