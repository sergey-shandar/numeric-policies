using System;

namespace NumericPolicies
{
    public struct IntPolicy : INumericPolicy<int>
    {
        public int Add(int a, int b)
            => a + b;

        public int Div(int a, int b)
            => a / b;

        public int FromLong(long v)
            => (int)v;

        public int Multiply(int a, int b)
            => a * b;

        public int Substract(int a, int b)
            => a - b;
    }
}
