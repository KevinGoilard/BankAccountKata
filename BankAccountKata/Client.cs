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
            }
            return new Operation("Deposit", date, amount);
        }

        public void Withdraw(Account account, Money amount)
        {
            if (account.Amount >= amount)
                account.Amount -= amount;
        }
    }
}
