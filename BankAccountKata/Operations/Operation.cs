using System;

namespace BankAccountKata.Operations
{
    public abstract class Operation
    {
        public const string DepositOperation = "Deposit";
        public const string WithdrawOperation = "Withdraw";
        public const string InvalidOperation = "Invalid";

        protected readonly DateTime date;
        protected readonly Money value;

        public Operation(DateTime date, Money value)
        {
            this.date = date;
            this.value = value;
        }

        public abstract Money ComputeBalance();

        public virtual bool IsValid()
        {
            return true;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Operation other = obj as Operation;
            return date.Equals(other.date) && value.Equals(other.value);
        }

        public override int GetHashCode()
        {
            return date.GetHashCode() + value.GetHashCode();
        }
    }
}
