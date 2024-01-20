using System;
using Classes;

namespace Dotnet_Csharp
{
    class Program
    {
        static void MainMain(string[] args)
        {
            Console.WriteLine("Hello World!");
            var account = new BankAccount("Ahn", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner}" +
                $"with {account.Balance} initial balance");

            Console.WriteLine("-----");

            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);

            BankAccount invalidAccount;
            try
            {
                invalidAccount = new BankAccount("Invalid", -55);

            } 
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
           
            }

            try
            {
                account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("-----");
            Console.WriteLine(account.GetAccountHistory());
        }

    }
}