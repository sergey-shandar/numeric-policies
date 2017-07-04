namespace NumericPolicies
{
    public struct MomentList1<T, P>
        where P : struct, INumericPolicy<T>
    {
        public T Sum { get; }

        public long Count { get; }

        public MomentList1(T sum, long count)
        {
            Sum = sum;
            Count = count;
        }

        public MomentList1<T, P> Add(MomentList1<T, P> b)
            => default(P).ToMomentList1(default(P).Add(Sum, b.Sum), Count + b.Count);

        public T Average
            => default(P).Div(Sum, default(P).FromLong(Count));
    }
}
