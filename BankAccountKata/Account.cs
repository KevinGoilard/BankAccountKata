using System;
using System.Collections.Generic;
using BankAccountKata.Operations;

namespace BankAccountKata
{
    public class Account
    {
        public Money Amount { get; private set; }
        public List<Operation> Historique { get; private set; }


        public Account() : this(new Money(0))
        {
        }

        public Account(Money initialValue)
        {
            Amount = initialValue;
            Historique = new List<Operation>();
        }

        internal Operation Deposit(Money amount, DateTime date)
        {
            Operation result = new InvalidOperation(date, amount);
            if (amount.ValueIsPositive())
            {
                Amount += amount;
                result = new DepositOperation(date, amount);
                //result = new Operation(Operation.DepositOperation, date, amount);
            }
            Historique.Add(result);
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
            Historique.Add(result);
            return result;
        }
    }
}
