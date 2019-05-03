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
            Printer printer = new Printer();
            return printer.FormatOperation(DepositOperation, date.ToLongDateString(), value.ToString(), ComputeBalance().ToString());
        }
    }
}
