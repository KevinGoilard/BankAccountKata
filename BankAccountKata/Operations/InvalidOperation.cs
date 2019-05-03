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
            Printer printer = new Printer();
            return printer.FormatOperation(InvalidOperation, date.ToLongDateString(), value.ToString(), ComputeBalance().ToString());
        }
    }
}
