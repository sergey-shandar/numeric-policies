using System;

namespace NumericPolicies
{
    public struct DecimalPolicy : INumericPolicy<decimal>
    {
        public decimal Add(decimal a, decimal b)
            => a + b;

        public decimal Div(decimal a, decimal b)
            => a / b;

        public decimal FromInt64(long v)
            => v;

        public decimal Multiply(decimal a, decimal b)
            => a * b;

        public decimal Substract(decimal a, decimal b)
            => a - b;
    }
}
