namespace NumericPolicies
{
    public interface INumericPolicy<T>
    {
        T FromInt64(long v);
        T Add(T a, T b);
        T Substract(T a, T b);
        T Multiply(T a, T b);
        T Div(T a, T b);
    }
}
