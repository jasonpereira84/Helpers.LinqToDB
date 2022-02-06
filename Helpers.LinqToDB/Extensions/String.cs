using System;
using System.Linq.Expressions;

namespace JasonPereira84.Helpers
{
    using LinqToDB;

    namespace Extensions
    {
        public static partial class LinqToDB
        {
            [ExpressionMethod("IsNullImpl")]
            public static Boolean IsNull(this String value)
                => value == null;
            public static Expression<Func<String, Boolean>> IsNullImpl()
                => value => IsNull(value);

            [ExpressionMethod("IsNotNull")]
            public static Boolean IsNotNull(this String value)
                => !IsNull(value);
            public static Expression<Func<String, Boolean>> IsNotNullImpl()
                => value => IsNotNull(value);

            [ExpressionMethod("IsEmptyImpl")]
            public static Boolean IsEmpty(this String value)
                => value.IsNull()
                    ? throw new ArgumentNullException(nameof(value))
                    : value.Length.Equals(0);
            public static Expression<Func<String, Boolean>> IsEmptyImpl()
                => value => IsEmpty(value);

            [ExpressionMethod("IsNotEmptyImpl")]
            public static Boolean IsNotEmpty(this String value)
                => !IsEmpty(value);
            public static Expression<Func<String, Boolean>> IsNotEmptyImpl()
                => value => IsNotEmpty(value);

            [ExpressionMethod("IsWhiteSpaceImpl")]
            public static Boolean IsWhiteSpace(this String value)
                => IsNotEmpty(value) && value.Trim().Length.Equals(0);
            public static Expression<Func<String, Boolean>> IsWhiteSpaceImpl()
                => value => IsWhiteSpace(value);

            [ExpressionMethod("IsNotWhiteSpaceImpl")]
            public static Boolean IsNotWhiteSpace(this String value)
                => !IsWhiteSpace(value);
            public static Expression<Func<String, Boolean>> IsNotWhiteSpaceImpl()
                => value => IsNotWhiteSpace(value);

            [ExpressionMethod("IsNullOrEmptyImpl")]
            public static Boolean IsNullOrEmpty(this String value)
                => IsNull(value) || value.Length.Equals(0);
            public static Expression<Func<String, Boolean>> IsNullOrEmptyImpl()
                => value => IsNullOrEmpty(value);

            [ExpressionMethod("IsNotNullOrEmptyImpl")]
            public static Boolean IsNotNullOrEmpty(this String value)
                => !IsNullOrEmpty(value);
            public static Expression<Func<String, Boolean>> IsNotNullOrEmptyImpl()
                => value => IsNotNullOrEmpty(value);

            [ExpressionMethod("IsEmptyOrWhiteSpaceImpl")]
            public static Boolean IsEmptyOrWhiteSpace(this String value)
                => IsEmpty(value) || value.Trim().Length.Equals(0);
            public static Expression<Func<String, Boolean>> IsEmptyOrWhiteSpaceImpl()
                => value => IsEmptyOrWhiteSpace(value);

            [ExpressionMethod("IsNotEmptyOrWhiteSpaceImpl")]
            public static Boolean IsNotEmptyOrWhiteSpace(this String value)
                => !IsEmptyOrWhiteSpace(value);
            public static Expression<Func<String, Boolean>> IsNotEmptyOrWhiteSpaceImpl()
                => value => IsNotEmptyOrWhiteSpace(value);

            [ExpressionMethod("IsNullOrEmptyOrWhiteSpaceImpl")]
            public static Boolean IsNullOrEmptyOrWhiteSpace(this String value)
                => String.IsNullOrWhiteSpace(value);
            public static Expression<Func<String, Boolean>> IsNullOrEmptyOrWhiteSpaceImpl()
                => value => IsNullOrEmptyOrWhiteSpace(value);

            [ExpressionMethod("IsNotNullOrEmptyOrWhiteSpaceImpl")]
            public static Boolean IsNotNullOrEmptyOrWhiteSpace(this String value)
                => !IsNullOrEmptyOrWhiteSpace(value);
            public static Expression<Func<String, Boolean>> IsNotNullOrEmptyOrWhiteSpaceImpl()
                => value => IsNotNullOrEmptyOrWhiteSpace(value);

        }
    }
}