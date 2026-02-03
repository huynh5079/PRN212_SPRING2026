using System;

namespace Lab4
{
    public delegate void BalanceChangedHandler(double newBalance);

    public class Account
    {
        public double Balance { get; private set; }
        public event BalanceChangedHandler BalanceChanged;

        public Account(double initialBalance)
        {
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            OnBalanceChanged(Balance);
        }

        public void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                OnBalanceChanged(Balance);
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        protected virtual void OnBalanceChanged(double newBalance)
        {
            if (BalanceChanged != null)
            {
                BalanceChanged(newBalance);
            }
        }
    }
}
