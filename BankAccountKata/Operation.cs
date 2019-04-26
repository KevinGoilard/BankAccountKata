using System;

namespace BankAccountKata
{
    public struct Operation
    {
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
