using System;
using System.Collections.Generic;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            Account bartosAccount = new Account("Barto's account", 100.00);
            Account bartosSwissAccount = new Account("Barto's account in Switzerland", 1000000.00);

            Console.WriteLine("Initial state");
            Console.WriteLine(bartosAccount);
            Console.WriteLine(bartosSwissAccount);

            bartosAccount.Withdrawal(20);
            Console.WriteLine("Barto's account balance is now: " + bartosAccount.Balance());
            bartosSwissAccount.Deposit(200);
            Console.WriteLine("Barto's Swiss account balance is now: " + bartosSwissAccount.Balance());

            Console.WriteLine("Final state");
            Console.WriteLine(bartosAccount);
            Console.WriteLine(bartosSwissAccount);
            Console.WriteLine();

            Account a = new Account("A", 100);
            Account b = new Account("B", 0);
            Account c = new Account("C", 0);
            Transfer(a, b, 50);
            Transfer(b, c, 25);
            var accounts = new List<Account>
            {
                a,
                b,
                c
            };
            foreach (var x in accounts)
            {
                Console.WriteLine(x.Balance());
            }
        }

        public static void test()
        {
            Account account = new Account("Account", 100);
            account.Deposit(20);
            Console.WriteLine(account.Balance());
        }

        public static void test2()
        {
            Account mattsAccount = new Account("Matt's account", 1000);
            Account myAccount = new Account("My account", 0);
            mattsAccount.Withdrawal(100);
            myAccount.Deposit(100);
            var accounts = new List<Account>
            {
                mattsAccount,
                myAccount
            };
            foreach (var x in accounts)
            {
                Console.WriteLine(x.Balance());
            }
        }

        public static void Transfer(Account from, Account to, double howMuch)
        {
            Account a = from;
            Account b = to;

            a.Withdrawal(howMuch);
            b.Deposit(howMuch);
        }
    }
}
