using System;

namespace BankAccountKata
{
    public class Client
    {
        public void Deposit(Account account, Money amount)
        {
            if (amount.ValueIsPositive())
            {
                account.Amount += amount;
            }
        }

        public void Withdraw(Account account, Money amount)
        {
            account.Amount = account.Amount.Sub(amount);
        }
    }
}
