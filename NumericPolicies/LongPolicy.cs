namespace NumericPolicies
{
    public struct LongPolicy : INumericPolicy<long>
    {
        public long Add(long a, long b)
            => a + b;

        public long Div(long a, long b)
            => a / b;

        public long FromLong(long v)
            => v;

        public long Multiply(long a, long b)
            => a * b;

        public long Substract(long a, long b)
            => a - b;
    }
}
