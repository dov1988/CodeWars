using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Collections;

namespace Katas.Kata55
{
 //In this Kata, we are going to reverse a string while maintaining the spaces (if any) in their original place.
//For example:
//solve("our code") = "edo cruo"
//-- Normal reversal without spaces is "edocruo". 
//-- However, there is a space at index 3, so the string becomes "edo cruo"
//solve("your code rocks") = "skco redo cruoy". 
//solve("codewars") = "srawedoc"

    public class Solution
    {
        public static string Solve(string s)
        {
            {
                StringBuilder stringBuilder = new StringBuilder(s.Length);
                foreach (char item in s)
                {
                    if (!char.IsWhiteSpace(item))
                    {
                        stringBuilder.Insert(0, item);
                    }
                }
                for (int i = 0; i < s.Length; i++)
                {
                    if (char.IsWhiteSpace(s[i]))
                    {
                        stringBuilder.Insert(i, s[i]);
                    }
                }
                return stringBuilder.ToString();
            }
        }
    }
    class UnitTest1
    {
        public class Tests
        {
            [SetUp]
            public void Setup()
            {
            }

            [Test]
            public void ExampleTests()
            {
                Assert.AreEqual("srawedoc", Solution.Solve("codewars"));
                Assert.AreEqual("edoc ruoy", Solution.Solve("your code"));
                Assert.AreEqual("skco redo cruoy", Solution.Solve("your code rocks"));
            }
        }
    }
}

