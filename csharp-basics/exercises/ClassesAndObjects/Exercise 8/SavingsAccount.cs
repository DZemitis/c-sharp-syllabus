namespace Exercise_8
{
    class SavingsAccount
    {

        private float _balance;
        private float _endBalance;
        public float AnnualInterestRate { get; set; }
        private float _totalDeposit;
        private float _totalWithdrawal;
        private float _monthlyInterest;
        private float _interestGain;

        public SavingsAccount(float startingBalance)
        {
            _balance = startingBalance;
        }

        public void Withdrawal(float withdrawalAmount)
        {
            _balance -= withdrawalAmount;
            _totalWithdrawal += withdrawalAmount;
        }

        public void Deposit(float depositAmount)
        {
            _balance += depositAmount;
            _totalDeposit += depositAmount;
        }

        public void OverallBalance(SavingsAccount account)
        {
            _endBalance = _balance + _interestGain;
        }
        public void MothlyInterest()
        {
            _monthlyInterest = AnnualInterestRate / 12;
        }

        public void AddInterestToBilance()
        {
            float interest = (_balance * _monthlyInterest);

            _interestGain += interest;
            _balance += interest;
        }

        public string DisplayBalance()
        {
            return $"{_balance: $0,00.00}";
        }

        public string DisplayInterestEarned()
        {
            return $"{_interestGain: $0,00.00}";
        }

        public string DisplayTotalWithdrawal()
        {
            return $"{_totalWithdrawal: $0,00.00}";
        }

        public string DisplayTotalDeposit()
        {
            return $"{_totalDeposit: $0,00.00}";
        }
    }
}