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
            if (account.Amount.Value > amount.Value)
                account.Amount -= amount;
        }
    }
}
