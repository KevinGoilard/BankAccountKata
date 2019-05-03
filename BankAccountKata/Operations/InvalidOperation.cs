using System;

namespace BankAccountKata.Operations
{
    public class InvalidOperation : Operation
    {
        public InvalidOperation(DateTime date, Money value) : base(date, value)
        {
        }

        public override Money ComputeBalance()
        {
            return new Money(0);
        }

        public override bool IsValid()
        {
            return false;
        }

        public override string ToString()
        {
            return string.Format("{0,-10}|{1,-30}|{2,10}|{3,10}", InvalidOperation, date.ToLongDateString(), value, ComputeBalance());
        }
    }
}
