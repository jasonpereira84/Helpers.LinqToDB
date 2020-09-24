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
        using Internal;

        public static partial class LinqToDB
        {
            [ExpressionMethod("IsNullImpl")]
            public static Boolean IsNull(this String @string) 
                => @string.IsNull();
            public static Expression<Func<String, Boolean>> IsNullImpl()
                => @string => @string.IsNull();

            [ExpressionMethod("IsEmptyImpl")]
            public static Boolean IsEmpty(this String @string)
                => @string.IsEmpty();
            public static Expression<Func<String, Boolean>> IsEmptyImpl()
                => @string => @string.IsEmpty();

            [ExpressionMethod("IsWhiteSpaceImpl")]
            public static Boolean IsWhiteSpace(this String @string)
                => @string.IsWhiteSpace();
            public static Expression<Func<String, Boolean>> IsWhiteSpaceImpl()
                => @string => @string.IsWhiteSpace();

            [ExpressionMethod("IsNullOrEmptyImpl")]
            public static Boolean IsNullOrEmpty(this String @string)
                => @string.IsNullOrEmpty();
            public static Expression<Func<String, Boolean>> IsNullOrEmptyImpl()
                => @string => @string.IsNullOrEmpty();

            [ExpressionMethod("IsEmptyOrWhiteSpaceImpl")]
            public static Boolean IsEmptyOrWhiteSpace(this String @string)
                => @string.IsEmptyOrWhiteSpace();
            public static Expression<Func<String, Boolean>> IsEmptyOrWhiteSpaceImpl()
                => @string => @string.IsEmptyOrWhiteSpace();

            [ExpressionMethod("IsNullOrEmptyOrWhiteSpaceImpl")]
            public static Boolean IsNullOrEmptyOrWhiteSpace(this String @string)
                => @string.IsNullOrEmptyOrWhiteSpace();
            public static Expression<Func<String, Boolean>> IsNullOrEmptyOrWhiteSpaceImpl()
                => @string => @string.IsNullOrEmptyOrWhiteSpace();


            [ExpressionMethod("IsNotNullImpl")]
            public static Boolean IsNotNull(this String @string)
                => !@string.IsNull();
            public static Expression<Func<String, Boolean>> IsNotNullImpl()
                => @string => !@string.IsNull();

            [ExpressionMethod("IsNotEmptyImpl")]
            public static Boolean IsNotEmpty(this String @string)
                => !@string.IsEmpty();
            public static Expression<Func<String, Boolean>> IsNotEmptyImpl()
                => @string => !@string.IsEmpty();

            [ExpressionMethod("IsNotWhiteSpaceImpl")]
            public static Boolean IsNotWhiteSpace(this String @string)
                => !@string.IsWhiteSpace();
            public static Expression<Func<String, Boolean>> IsNotWhiteSpaceImpl()
                => @string => !@string.IsWhiteSpace();

            [ExpressionMethod("IsNotNullOrEmptyImpl")]
            public static Boolean IsNotNullOrEmpty(this String @string)
                => !@string.IsNullOrEmpty();
            public static Expression<Func<String, Boolean>> IsNotNullOrEmptyImpl()
                => @string => !@string.IsNullOrEmpty();

            [ExpressionMethod("IsNotEmptyOrWhiteSpaceImpl")]
            public static Boolean IsNotEmptyOrWhiteSpace(this String @string)
                => !@string.IsEmptyOrWhiteSpace();
            public static Expression<Func<String, Boolean>> IsNotEmptyOrWhiteSpaceImpl()
                => @string => !@string.IsEmptyOrWhiteSpace();

            [ExpressionMethod("IsNotNullOrEmptyOrWhiteSpaceImpl")]
            public static Boolean IsNotNullOrEmptyOrWhiteSpace(this String @string)
                => !@string.IsNullOrEmptyOrWhiteSpace();
            public static Expression<Func<String, Boolean>> IsNotNullOrEmptyOrWhiteSpaceImpl()
                => @string => !@string.IsNullOrEmptyOrWhiteSpace();

        }
    }
}