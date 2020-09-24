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
            [ExpressionMethod("InImpl")]
            public static Boolean In<T>(this T item, IEnumerable<T> items)
                => items.Contains(item);
            public static Expression<Func<T, IEnumerable<T>, Boolean>> InImpl<T>()
                => (item, items) => items.Contains(item);

            [ExpressionMethod("NotInImpl")]
            public static Boolean NotIn<T>(this T item, IEnumerable<T> items)
                => !items.Contains(item);
            public static Expression<Func<T, IEnumerable<T>, Boolean>> NotInImpl<T>()
                => (item, items) => !items.Contains(item);

        }
    }
}