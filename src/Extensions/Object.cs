using System;
using System.Linq;
using System.Collections;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace TeamHealth.Helpers
{
    using global::LinqToDB;

    namespace Extensions
    {
        public static partial class LinqToDB
        {
            [ExpressionMethod("NotEqualsImpl")]
            public static Boolean NotEquals<T>(this T item, T otherItem)
                => !item.Equals(otherItem);
            public static Expression<Func<T, T, Boolean>> NotEqualsImpl<T>()
                => (item, otherItem) => !item.Equals(otherItem);

            [ExpressionMethod("HasNoValueImpl")]
            public static Boolean HasNoValue<T>(this Nullable<T> item) where T : struct
                => !item.HasValue;
            public static Expression<Func<Nullable<T>, Boolean>> HasNoValueImpl<T>() where T : struct
                => item => !item.HasValue;
        }
    }
}