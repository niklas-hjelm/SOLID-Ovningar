using System;
using WorkshopHandsOn26.Banks;
using WorkshopHandsOn26.ValueObject;

namespace WorkshopHandsOn26
{
    class Program
    {
        static void Main(string[] args)
        {
            SocialSecurityNumber owner = SocialSecurityNumber.Create(19650321999, "Bernt Johansson");
            IAccount account = Account.Create(owner);
            IBank bank = SwedBank.Create(account);

            bank.Deposit(account.Identifier.Id, 450)
                .Deposit(account.Identifier.Id, 500);

            bank.Withdraw(account.Identifier.Id, 2500)
                .Withdraw(account.Identifier.Id, 1500);

            SocialSecurityNumber owner1 = SocialSecurityNumber.Create(198809011234, "Kalle Karlsson");
            IAccount secondAccount = Account.Create(owner1);
            bank.OpenAccount(secondAccount);
            bank.Deposit(secondAccount.Identifier.Id, 450);

            Console.ReadKey();
        }
    }
}
