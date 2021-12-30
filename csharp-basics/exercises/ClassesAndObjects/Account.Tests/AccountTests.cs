using System;
using Xunit;

namespace Account.Tests
{
    public class AccountTests
    {
        private Account _target;

        public AccountTests()
        {
            _target = new Account("Davis", 500);
        }
        
        [Fact]
        public void Balance_Balanceis500_ShouldReturn500()
        {
            //Arrange
            var expectedBalance = 500;

            //Act
            var givenBalance = _target.Balance();

            //Assert
            Assert.Equal(expectedBalance,givenBalance);
        }
        
        [Fact]
        public void Withdrawal_Withdraw350fromBalance_ShouldReturnBalance150()
        {
            //Arrange
            var expectedBalanceAfterWithdrawal = 150;

            //Act
            var givenBalance = _target.Withdrawal(350);

            //Assert
            Assert.Equal(expectedBalanceAfterWithdrawal,givenBalance);
        }
        
        [Fact]
        public void Deposit_Deposit350ToBalance_ShouldReturnBalance850()
        {
            //Arrange
            var expectedBalanceAfterWithdrawal = 850;

            //Act
            var givenBalance = _target.Deposit(350);

            //Assert
            Assert.Equal(expectedBalanceAfterWithdrawal,givenBalance);
        }
        
        [Fact]
        public void Print_PrintNameAndBalance_ShouldContainNameAndBalance()
        {
            //Arrange
            var name = "Davis";
            var money = 500;

            //Act
            var accountToString = _target.ToString();

            //Assert
            Assert.Contains($"{name}: {money}",accountToString);
        }
    }
}