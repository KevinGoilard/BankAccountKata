using System;

namespace BankAccountKata
{
    public class Account
    {
        public Money Amount { get; private set; }

        public Account()
        {
            Amount = new Money(0);
        }

        public Account(Money initialValue)
        {
            Amount = initialValue;
        }

        internal Operation Deposit(Money amount, DateTime date)
        {
            if (amount.ValueIsPositive())
            {
                Amount += amount;
                return new Operation("Deposit", date, amount);
            }
            return new Operation("Invalid", date, amount);
        }
        internal Operation Withdraw(Money amount, DateTime date)
        {
            if (amount.ValueIsPositive() && Amount >= amount)
            {
                Amount -= amount;
                return new Operation("Withdraw", date, amount);
            }
            return new Operation("Invalid", date, amount);
        }
    }
}
