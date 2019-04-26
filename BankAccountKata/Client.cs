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
            return account.Deposit(amount, date);
        }

        public Operation Withdraw(Account account, Money amount)
        {
            return Withdraw(account, amount, DateTime.Now);
        }

        public Operation Withdraw(Account account, Money amount, DateTime date)
        {
            return account.Withdraw(amount, date);
        }
    }
}
