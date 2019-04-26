﻿using System;

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

        public static Money operator +(Money firstValue, Money secondValue)
        {
            return firstValue.Sum(secondValue);
        }

        public static Money operator -(Money firstValue, Money secondValue)
        {
            return firstValue.Sub(secondValue);
        }
    }
}
