using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountKata.Operations
{
    public class WithdrawOperation : Operation
    {
        public WithdrawOperation(DateTime date, Money value) : base(date, value)
        {
        }

        public override Money ComputeBalance()
        {
            return -value;
        }

        public override string ToString()
        {
            Printer printer = new Printer();
            return printer.FormatOperation(WithdrawOperation, date.ToLongDateString(), value.ToString(), ComputeBalance().ToString());
        }
    }
}
