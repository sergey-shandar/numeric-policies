namespace NumericPolicies
{
    public struct Numeric<T, P>
        where P : struct, INumericPolicy<T>
    {
        public T Value { get; }

        public Numeric(T value)
        {
            Value = value;
        }

        public Numeric<T, P> Add(T b)
            => default(P).Add(Value, b).Numeric<T, P>();

        public Numeric<T, P> Substract(T b)
            => default(P).Substract(Value, b).Numeric<T, P>();

        public Numeric<T, P> Multiply(T b)
            => default(P).Multiply(Value, b).Numeric<T, P>();

        public Numeric<T, P> Div(T b)
            => default(P).Div(Value, b).Numeric<T, P>();

        public static implicit operator T(Numeric<T, P> numeric)
            => numeric.Value;
    }
}
