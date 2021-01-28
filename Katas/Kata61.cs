using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Katas.Kata61
{
//Define a function that takes one integer argument and returns logical value true or false depending on if the integer is a prime.
//Per Wikipedia, a prime number (or a prime) is a natural number greater than 1 that has no positive divisors other than 1 and itself.
//Requirements
//You can assume you will be given an integer input.
//You can not assume that the integer will be only positive.You may be given negative numbers as well (or 0).
//NOTE on performance: There are no fancy optimizations required, but still the most trivial solutions might time out. Numbers go up to 2^31 (or similar, depends on language version). Looping all the way up to n, or n/2, will be too slow.

    public static class Kata
    {
        public static bool IsPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
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
                [TestFixture]
                public class SolutionTest
                {
                    private static IEnumerable<TestCaseData> sampleTestCases
                    {
                        get
                        {
                            yield return new TestCaseData(0).Returns(false);
                            yield return new TestCaseData(1).Returns(false);
                            yield return new TestCaseData(2).Returns(true);
                        }
                    }

                    [Test, TestCaseSource("sampleTestCases")]
                    public bool SampleTest(int n) => Kata.IsPrime(n);
                }
            }
        }
    }

