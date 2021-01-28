using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Katas.Kata62
{
    //Digital root is the recursive sum of all the digits in a number.
    //Given n, take the sum of the digits of n. If that value has more than one digit, continue reducing in this way until a single-digit number is produced.This is only applicable to the natural numbers.
    //Examples:
    //16  -->  1 + 6 = 7
    //942  -->  9 + 4 + 2 = 15  -->  1 + 5 = 6
    //132189  -->  1 + 3 + 2 + 1 + 8 + 9 = 24  -->  2 + 4 = 6
    //493193  -->  4 + 9 + 3 + 1 + 9 + 3 = 29  -->  2 + 9 = 11  -->  1 + 1 = 2

    public class Number
    {
        public int DigitalRoot(long n)
        {
            if (n >= 0 && n <= 9)
            {
                return (int)n;
            }
            string number = n.ToString();
            double sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += char.GetNumericValue(number[i]);
            }
            return DigitalRoot((long)sum);
        }
    }

    public class NumberTest
    {
        private Number num;

        [SetUp]
        public void SetUp()
        {
            num = new Number();
        }

        [TearDown]
        public void TearDown()
        {
            num = null;
        }

        [Test]
        public void Tests()
        {
            Assert.AreEqual(7, num.DigitalRoot(16));
            Assert.AreEqual(6, num.DigitalRoot(456));
        }
    }
}

