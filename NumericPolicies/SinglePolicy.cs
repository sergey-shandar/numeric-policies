namespace NumericPolicies
{
    public struct SinglePolicy : INumericPolicy<float>
    {
        public float Add(float a, float b)
            => a + b;

        public float Div(float a, float b)
            => a / b;

        public float FromInt64(long v)
            => v;

        public float Multiply(float a, float b)
            => a * b;

        public float Substract(float a, float b)
            => a - b;
    }
}
