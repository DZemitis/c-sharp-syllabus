using System;

namespace BankAccount
{
    class BankAccount
    {
        private string _accountName;
        private double _accountBalance;

        public BankAccount(string accountName, double accountBalance)
        {
            _accountBalance = accountBalance;
            _accountName = accountName;
        }

        public void ShowUserNameAndBalance()
        {
            if (_accountBalance < 0)
            {
                Console.WriteLine($"{_accountName}, {-1 *_accountBalance: -$00.00}");
            }
            else
            {
                Console.WriteLine($"{_accountName}, {_accountBalance: $00.00}");
            }
        }
    }
}