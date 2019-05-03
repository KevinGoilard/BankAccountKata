using System;
using System.Collections.Generic;
using BankAccountKata.Operations;

namespace BankAccountKata
{
    public class Account
    {
        public Money Amount { get; private set; }
        private readonly History history;


        public Account() : this(new Money(0))
        {
        }

        public Account(Money initialValue)
        {
            Amount = initialValue;
            history = new History();
        }

        public List<string> GetOperationStrings()
        {
            return history.GetOperationStrings();
        }

        public List<string> GetOnlyValidOperationStrings()
        {
            return history.GetOnlyValidOperationStrings();
        }

        public Money ComputeBalance()
        {
            return history.ComputeBalance();
        }

        internal Operation Deposit(Money amount, DateTime date)
        {
            Operation result = new InvalidOperation(date, amount);
            if (amount.ValueIsPositive())
            {
                Amount += amount;
                result = new DepositOperation(date, amount);
            }
            history.Add(result);
            return result;
        }

        internal Operation Withdraw(Money amount, DateTime date)
        {
            Operation result = new InvalidOperation(date, amount);
            if (amount.ValueIsPositive() && Amount >= amount)
            {
                Amount -= amount;
                result = new WithdrawOperation(date, amount);
            }
            history.Add(result);
            return result;
        }
    }
}
