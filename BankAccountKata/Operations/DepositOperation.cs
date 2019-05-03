using System;

namespace BankAccountKata.Operations
{
    public class DepositOperation : Operation
    {
        public DepositOperation(DateTime date, Money value) : base(date, value)
        {
        }

        public override Money ComputeBalance()
        {
            return value;
        }

        public override string ToString()
        {
            return string.Format("{0,-10}|{1,-30}|{2,10}|{3,10}", DepositOperation, date.ToLongDateString(), value, ComputeBalance());
        }
    }
}
