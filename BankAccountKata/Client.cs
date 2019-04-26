using System;

namespace BankAccountKata
{
    public class Client
    {
        public Operation Deposit(Account account, Money amount)
        {
            return Deposit(account, amount, DateTime.Now);
        }

        public Operation Deposit(Account account, Money amount, DateTime date)
        {
            if (amount.ValueIsPositive())
            {
                account.Amount += amount;
                return new Operation("Deposit", date, amount);
            }
            return new Operation("Invalid", date, amount);
        }

        public Operation Withdraw(Account account, Money amount)
        {
            return Withdraw(account, amount, DateTime.Now);
        }

        public Operation Withdraw(Account account, Money amount, DateTime date)
        {
            if (account.Amount >= amount)
                account.Amount -= amount;
            return new Operation("Withdraw", date, amount);
        }
    }
}
