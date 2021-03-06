﻿namespace NumericPolicies
{
    public static class NumericExtensions
    {
        public static Numeric<T, P> Numeric<T, P>(this T value, P _)
            where P : struct, INumericPolicy<T>
            => new Numeric<T, P>(value);

        public static Numeric<T, P> Numeric<T, P>(this T value)
            where P : struct, INumericPolicy<T>
            => new Numeric<T, P>(value);

        public static Numeric<T, P> ToNumeric<T, P>(this long v)
            where P : struct, INumericPolicy<T>
            => default(P).FromInt64(v).Numeric<T, P>();

        public static MomentList1<T, P> MomentList1<T, P>(this Numeric<T, P> value, long count)
            where P : struct, INumericPolicy<T>
            => new MomentList1<T, P>(value, count);

        public static MomentList1<T, P> MomentList1<T, P>(this Numeric<T, P> value)
            where P : struct, INumericPolicy<T>
            => value.MomentList1(1);
    }
}
