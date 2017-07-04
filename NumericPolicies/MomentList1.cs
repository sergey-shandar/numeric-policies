namespace NumericPolicies
{
    public struct MomentList1<T, P>
        where P : struct, INumericPolicy<T>
    {
        public Numeric<T, P> Sum { get; }

        public long Count { get; }

        public MomentList1(Numeric<T, P> sum, long count)
        {
            Sum = sum;
            Count = count;
        }

        public MomentList1<T, P> Add(MomentList1<T, P> b)
            => Sum.Add(b.Sum).MomentList1(Count + b.Count);

        public T Average
            => Sum.Div(Count.ToNumeric<T, P>());
    }
}
