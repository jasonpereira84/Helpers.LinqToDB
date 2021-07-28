using System;
using System.Linq;
using System.Collections;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace JasonPereira84.Helpers
{
    using global::LinqToDB;

    namespace Extensions
    {
        public static partial class LinqToDB
        {
            [ExpressionMethod("IsNullImpl")]
            public static Boolean IsNull(this String @string) 
                => _internalHelpers.IsNull(@string);
            public static Expression<Func<String, Boolean>> IsNullImpl()
                => @string => _internalHelpers.IsNull(@string);

            [ExpressionMethod("IsEmptyImpl")]
            public static Boolean IsEmpty(this String @string)
                => _internalHelpers.IsEmpty(@string);
            public static Expression<Func<String, Boolean>> IsEmptyImpl()
                => @string => _internalHelpers.IsEmpty(@string);

            [ExpressionMethod("IsWhiteSpaceImpl")]
            public static Boolean IsWhiteSpace(this String @string)
                => _internalHelpers.IsWhiteSpace(@string);
            public static Expression<Func<String, Boolean>> IsWhiteSpaceImpl()
                => @string => _internalHelpers.IsWhiteSpace(@string);

            [ExpressionMethod("IsNullOrEmptyImpl")]
            public static Boolean IsNullOrEmpty(this String @string)
                => _internalHelpers.IsNullOrEmpty(@string);
            public static Expression<Func<String, Boolean>> IsNullOrEmptyImpl()
                => @string => _internalHelpers.IsNullOrEmpty(@string);

            [ExpressionMethod("IsEmptyOrWhiteSpaceImpl")]
            public static Boolean IsEmptyOrWhiteSpace(this String @string)
                => _internalHelpers.IsEmptyOrWhiteSpace(@string);
            public static Expression<Func<String, Boolean>> IsEmptyOrWhiteSpaceImpl()
                => @string => _internalHelpers.IsEmptyOrWhiteSpace(@string);

            [ExpressionMethod("IsNullOrEmptyOrWhiteSpaceImpl")]
            public static Boolean IsNullOrEmptyOrWhiteSpace(this String @string)
                => _internalHelpers.IsNullOrEmptyOrWhiteSpace(@string);
            public static Expression<Func<String, Boolean>> IsNullOrEmptyOrWhiteSpaceImpl()
                => @string => _internalHelpers.IsNullOrEmptyOrWhiteSpace(@string);


            [ExpressionMethod("IsNotNullImpl")]
            public static Boolean IsNotNull(this String @string)
                => !_internalHelpers.IsNull(@string);
            public static Expression<Func<String, Boolean>> IsNotNullImpl()
                => @string => !_internalHelpers.IsNull(@string);

            [ExpressionMethod("IsNotEmptyImpl")]
            public static Boolean IsNotEmpty(this String @string)
                => !_internalHelpers.IsEmpty(@string);
            public static Expression<Func<String, Boolean>> IsNotEmptyImpl()
                => @string => !_internalHelpers.IsEmpty(@string);

            [ExpressionMethod("IsNotWhiteSpaceImpl")]
            public static Boolean IsNotWhiteSpace(this String @string)
                => !_internalHelpers.IsWhiteSpace(@string);
            public static Expression<Func<String, Boolean>> IsNotWhiteSpaceImpl()
                => @string => !_internalHelpers.IsWhiteSpace(@string);

            [ExpressionMethod("IsNotNullOrEmptyImpl")]
            public static Boolean IsNotNullOrEmpty(this String @string)
                => !_internalHelpers.IsNullOrEmpty(@string);
            public static Expression<Func<String, Boolean>> IsNotNullOrEmptyImpl()
                => @string => !_internalHelpers.IsNullOrEmpty(@string);

            [ExpressionMethod("IsNotEmptyOrWhiteSpaceImpl")]
            public static Boolean IsNotEmptyOrWhiteSpace(this String @string)
                => !_internalHelpers.IsEmptyOrWhiteSpace(@string);
            public static Expression<Func<String, Boolean>> IsNotEmptyOrWhiteSpaceImpl()
                => @string => !_internalHelpers.IsEmptyOrWhiteSpace(@string);

            [ExpressionMethod("IsNotNullOrEmptyOrWhiteSpaceImpl")]
            public static Boolean IsNotNullOrEmptyOrWhiteSpace(this String @string)
                => !_internalHelpers.IsNullOrEmptyOrWhiteSpace(@string);
            public static Expression<Func<String, Boolean>> IsNotNullOrEmptyOrWhiteSpaceImpl()
                => @string => !_internalHelpers.IsNullOrEmptyOrWhiteSpace(@string);

        }
    }
}