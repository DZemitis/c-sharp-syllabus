using System;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much money is in the account?");
            var input = float.Parse(Console.ReadLine());
            var account1 = new SavingsAccount(input);

            Console.WriteLine("Enter annual interest rate");
            account1.AnnualInterestRate = float.Parse(Console.ReadLine());

            Console.WriteLine("How long has the account been opened?");
            int monthsSinceOpen = int.Parse(Console.ReadLine());

            int month = 1;
            for (month = 1; month <= monthsSinceOpen; month++)
            {
                Console.WriteLine($"Enter amount deposited for month: {month}:");
                var userDeposit = float.Parse(Console.ReadLine());
                account1.Deposit(userDeposit);


                Console.WriteLine($"Enter amount withdrawn for month: {month}:");
                var userWithdrawal = float.Parse(Console.ReadLine());
                account1.Withdrawal(userWithdrawal);

                account1.MonthlyInterest();
                account1.AddInterestToBalance();
            }

            Console.WriteLine($"Total deposited:{account1.DisplayTotalDeposit()}");
            Console.WriteLine($"Total withdrawn:{account1.DisplayTotalWithdrawal()}");
            Console.WriteLine($"Interest earned:{account1.DisplayInterestEarned()}");
            Console.WriteLine($"Ending balance:{account1.DisplayBalance()}");
        }
    }
}

