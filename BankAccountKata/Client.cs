﻿using System;

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
