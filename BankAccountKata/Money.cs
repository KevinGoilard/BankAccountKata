using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountKata
{
    public struct Money
    {
        public int Value { get; }

        public Money(int value)
        {
            this.Value = value;
        }

        public bool ValueIsPositive()
        {
            return Value > 0;
        }

        public Money Sum(Money money)
        {
            return new Money(Value + money.Value);
        }
    }
}
