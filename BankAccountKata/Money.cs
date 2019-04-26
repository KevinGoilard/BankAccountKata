using System;

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

        internal Money Sum(Money money)
        {
            return new Money(Value + money.Value);
        }

        internal Money Sub(Money money)
        {
            return new Money(Value - money.Value);
        }

        internal bool IsMoreThan(Money money)
        {
            return Value > money.Value;
        }

        internal bool IsLessThan(Money money)
        {
            return Value < money.Value;
        }

        public static Money operator +(Money firstValue, Money secondValue)
        {
            return firstValue.Sum(secondValue);
        }

        public static Money operator -(Money firstValue, Money secondValue)
        {
            return firstValue.Sub(secondValue);
        }

        public static Money operator -(Money money)
        {
            return new Money(-money.Value);
        }

        public static bool operator >(Money firstValue, Money secondValue)
        {
            return firstValue.IsMoreThan(secondValue);
        }

        public static bool operator <(Money firstValue, Money secondValue)
        {
            return firstValue.IsLessThan(secondValue);
        }

        public static bool operator >=(Money firstValue, Money secondValue)
        {
            return firstValue.Value == secondValue.Value || firstValue > secondValue;
        }

        public static bool operator <=(Money firstValue, Money secondValue)
        {
            return firstValue.Value == secondValue.Value || firstValue < secondValue;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
