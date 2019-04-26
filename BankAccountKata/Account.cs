using System;
using System.Collections.Generic;

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
            Operation result = new Operation(Operation.InvalidOperation, date, amount);
            if (amount.ValueIsPositive())
            {
                Amount += amount;
                result = new Operation(Operation.DepositOperation, date, amount);
            }
            Historique.Add(result);
            return result;
        }

        internal Operation Withdraw(Money amount, DateTime date)
        {
            Operation result = new Operation(Operation.InvalidOperation, date, amount);
            if (amount.ValueIsPositive() && Amount >= amount)
            {
                Amount -= amount;
                result = new Operation(Operation.WithdrawOperation, date, amount);
            }
            Historique.Add(result);
            return result;
        }

        public override string ToString()
        {
            string content = string.Format("{0,-10}\t{1,-20}\t{2,-10}\t{3,-10}\n", "Operation", "Date", "Valeur", "Balance");
            Printer printer = new Printer();
            content += printer.ComputeHistory(this);
            return content;
            
        }
    }
}
