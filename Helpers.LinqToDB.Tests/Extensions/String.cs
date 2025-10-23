using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JasonPereira84.Helpers.LinqToDB.Tests
{
    namespace Extensions
    {
        using JasonPereira84.Helpers.Extensions;

        [TestClass]
        public class Test_String
        {
            [TestMethod]
            public void IsNull()
            {
                {
                    var @string = default(String);
                    Assert.IsTrue(@string.IsNull());
                }

                {
                    var @string = (String)null;
                    Assert.IsTrue(@string.IsNull());
                }

                {
                    var @string = "hello";
                    Assert.IsFalse(@string.IsNull());
                }
            }

            [TestMethod]
            public void IsEmpty()
            {
                {
                    var @string = default(String);
                    Assert.Throws<ArgumentNullException>(
                        () => @string.IsEmpty());
                }

                {
                    var @string = "";
                    Assert.IsTrue(@string.IsEmpty());
                }

                {
                    var @string = String.Empty;
                    Assert.IsTrue(@string.IsEmpty());
                }

                {
                    var @string = " ";
                    Assert.IsFalse(@string.IsEmpty());
                }

                {
                    var @string = "hello";
                    Assert.IsFalse(@string.IsEmpty());
                }
            }
            
            [TestMethod]
            public void IsWhiteSpace()
            {
                {
                    var @string = default(String);
                    Assert.Throws<ArgumentNullException>(
                        () => @string.IsWhiteSpace());
                }

                {
                    var @string = " ";
                    Assert.IsTrue(@string.IsWhiteSpace());
                }

                {
                    var @string = "";
                    Assert.IsFalse(@string.IsWhiteSpace());
                }

                {
                    var @string = "hello";
                    Assert.IsFalse(@string.IsWhiteSpace());
                }
            }
            
            [TestMethod]
            public void IsNullOrEmpty()
            {
                {
                    var @string = default(String);
                    Assert.IsTrue(@string.IsNullOrEmpty());
                }

                {
                    var @string = String.Empty;
                    Assert.IsTrue(@string.IsNullOrEmpty());
                }

                {
                    var @string = "";
                    Assert.IsTrue(@string.IsNullOrEmpty());
                }

                {
                    var @string = " ";
                    Assert.IsFalse(@string.IsNullOrEmpty());
                }

                {
                    var @string = "hello";
                    Assert.IsFalse(@string.IsNullOrEmpty());
                }
            }
            
            [TestMethod]
            public void IsEmptyOrWhiteSpace()
            {
                {
                    var @string = default(String);
                    Assert.Throws<ArgumentNullException>(
                        () => @string.IsWhiteSpace());
                }

                {
                    var @string = String.Empty;
                    Assert.IsTrue(@string.IsEmptyOrWhiteSpace());
                }

                {
                    var @string = "";
                    Assert.IsTrue(@string.IsEmptyOrWhiteSpace());
                }

                {
                    var @string = " ";
                    Assert.IsTrue(@string.IsEmptyOrWhiteSpace());
                }

                {
                    var @string = "hello";
                    Assert.IsFalse(@string.IsEmptyOrWhiteSpace());
                }
            }
            
        }
    }
}
