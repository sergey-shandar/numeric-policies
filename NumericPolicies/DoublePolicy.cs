using System;

namespace NumericPolicies
{
    public struct DoublePolicy : INumericPolicy<double>
    {
        public double Add(double a, double b)
            => a + b;

        public double Div(double a, double b)
            => a / b;

        public double FromLong(long v)
            => v;

        public double Multiply(double a, double b)
            => a * b;

        public double Substract(double a, double b)
            => a - b;
    }
}
