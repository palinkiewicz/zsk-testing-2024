namespace Library
{
    public class BankAccount
    {
        public double Money { get; private set; }

        public BankAccount()
        {
            Money = 0;
        }

        public double GetBalance()
        {
            return Money;
        }

        public bool Deposit(double amount)
        {
            if (amount < 0)
            {
                return false;
            }

            checked
            {
                Money += amount;
            }

            return true;
        }

        public bool Withdraw(double amount)
        {
            if (amount < 0)
            {
                return false;
            }

            if (amount > Money)
            {
                return false;
            }

            checked
            {
                Money -= amount;
            }

            return true;
        }
    }
}
