using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Katas.Kata51
{
    //Create a function that returns the sum of the two lowest positive numbers given an array of minimum 4 positive integers.No floats or non-positive integers will be passed.
    //For example, when an array is passed like [19, 5, 42, 2, 77], the output should be 7.
    //[10, 343445353, 3453445, 3453545353453] should return 3453455.
    public static class Kata
    {
        public static int sumTwoSmallestNumbers(int[] numbers) => numbers.OrderBy(x => x).ToArray().Take(2).Sum();
        //{
        //    Array.Sort(numbers);
        //    return numbers[0] + numbers[1]; 
        //}
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
            public void Test1()
            {
                int[] numbers = { 5, 8, 12, 19, 22 };
                Assert.AreEqual(13, Kata.sumTwoSmallestNumbers(numbers));
            }
        }
    }
}

