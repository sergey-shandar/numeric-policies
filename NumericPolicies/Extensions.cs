namespace NumericPolicies
{
    public static class NumericExtensions
    {
        public static MomentList1<T, P> ToMomentList1<T, P>(this P _, T value, long count)
            where P : struct, INumericPolicy<T>
            => new MomentList1<T, P>(value, count);

        public static MomentList1<T, P> ToMomentList1<T, P>(this P _, T value)
            where P : struct, INumericPolicy<T>
            => default(P).ToMomentList1(value, 1);

        public static MomentList1<T, P> ToMomentList1<T, P>(this P _)
            where P : struct, INumericPolicy<T>
            => default(P).ToMomentList1(default(P).FromLong(0), 0);
    }
}
