namespace NumericPolicies
{
    public struct Int64Policy : INumericPolicy<long>
    {
        public long Add(long a, long b)
            => a + b;

        public long Div(long a, long b)
            => a / b;

        public long FromInt64(long v)
            => v;

        public long Multiply(long a, long b)
            => a * b;

        public long Substract(long a, long b)
            => a - b;
    }
}
