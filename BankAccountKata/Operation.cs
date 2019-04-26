using System;

namespace BankAccountKata
{
    public struct Operation
    {
        public const string DepositOperation = "Deposit";
        public const string WithdrawOperation = "Withdraw";
        public const string InvalidOperation = "Invalid";

        private readonly string operationType;
        private readonly DateTime date;
        private readonly Money value;

        public Operation(string operationType, DateTime date, Money value)
        {
            this.operationType = operationType;
            this.date = date;
            this.value = value;
        }

        public Money ComputeBalance()
        {
            if (operationType == DepositOperation)
                return value;
            if (operationType == WithdrawOperation)
                return -value;
            return new Money(0);
        }

        public bool IsValid()
        {
            return operationType != InvalidOperation;
        }

        public override string ToString()
        {
            return string.Format("{0,-10}|{1,-30}|{2,10}|{3,10}", operationType, date.ToLongDateString(), value, ComputeBalance());
        }
    }
}
