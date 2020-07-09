using System;

namespace Practice_07_09_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Frank", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

            account.MakeWithdrawal(120, DateTime.Now, "Item");
            Console.WriteLine(account.Balance);

            account.MakeDeposit(300, DateTime.Now, "Deposit 1");

            Console.WriteLine(account.GetAccountHistory());

        }
    }
}
