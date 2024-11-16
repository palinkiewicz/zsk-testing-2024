using Library;

namespace Library.Tests
{
    /// <summary>
    /// ADAM PALINKIEWICZ NR 13
    /// </summary>
    public class BankAccountTests
    {
        [Fact]
        public void BankAccount_GetBalance_ReturnsCorrectBalance()
        {
            BankAccount bankAccount = new BankAccount();
            int added = 10;
            int expected = 10;

            bankAccount.Deposit(added);

            Assert.Equal(expected, bankAccount.GetBalance());
        }

        [Fact]
        public void BankAccount_DepositNegativeBalance_ReturnsFalse()
        {
            BankAccount bankAccount = new BankAccount();
            int added = -10;

            bool result = bankAccount.Deposit(added);

            Assert.False(result);
        }

        [Fact]
        public void BankAccount_WithdrawNegativeBalance_ReturnsFalse()
        {
            BankAccount bankAccount = new BankAccount();
            int taken = -10;

            bool result = bankAccount.Withdraw(taken);

            Assert.False(result);
        }

        [Fact]
        public void BankAccount_WithdrawTooMuch_ReturnsFalse()
        {
            BankAccount bankAccount = new BankAccount();
            int taken = 10;

            bool result = bankAccount.Withdraw(taken);

            Assert.False(result);
        }

        [Fact]
        public void BankAccount_WithdrawJustOkay_ReturnsTrue()
        {
            BankAccount bankAccount = new BankAccount();
            int added = 10;
            int taken = 10;

            bankAccount.Deposit(added);
            bool result = bankAccount.Withdraw(taken);

            Assert.True(result);
        }
    }
}
