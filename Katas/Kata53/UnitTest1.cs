using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Katas.Kata53
{
    //Write function alternateCase which switch every letter in string from upper to lower and from lower to upper.E.g: Hello World -> hELLO wORLD

        public static class Program
        {
        public static string alternateCase(string s)
            {
                string result = "";
                foreach (char item in s)
                {
                    if (char.IsLetter(item))
                    {
                        if (char.IsLower(item))
                        {
                            result += char.ToUpper(item);
                        }
                        else
                        {
                            result += char.ToLower(item);
                        }

                    }
                    else { result += item; }
                }
            string str = (string)s.Reverse();
                return result;
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
            public void MyTest()
            {
                Assert.AreEqual("ABC", Program.alternateCase("abc"));
                Assert.AreEqual("abc", Program.alternateCase("ABC"));
                Assert.AreEqual("hELLO wORLD", Program.alternateCase("Hello World"));
            }
        }
    }
}

