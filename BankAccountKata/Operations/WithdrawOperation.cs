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
            return string.Format("{0,-10}|{1,-30}|{2,10}|{3,10}", WithdrawOperation, date.ToLongDateString(), value, ComputeBalance());
        }
    }
}
