using System;

namespace BankAccountKata
{
    public struct Operation
    {
        public const string DepositOperation = "Deposit";
        public const string WithdrawOperation = "WithDraw";
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
    }
}
