using NUnit.Framework;
using System;

namespace Kata15
{
    public class Kata
    {
     //The purpose of this kata is to work out just how many bottles of duty free whiskey you would have to buy such that the saving over the normal high street price would effectively cover the cost of your holiday.
     //You will be given the high street price (normPrice), the duty free discount (discount) and the cost of the holiday.
     //For example, if a bottle cost £10 normally and the discount in duty free was 10%, you would save £1 per bottle. If your holiday cost £500, the answer you should return would be 500.
     //All inputs will be integers.Please return an integer. Round down.
        public static int DutyFree(int normPrice, int Discount, int hol)
        {
            double discountSum = (double)(normPrice * Discount) / 100;
            int count = (int)(hol / discountSum);
            return count;
        }
    }
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(166, Kata.DutyFree(12, 50, 1000));
            Assert.AreEqual(294, Kata.DutyFree(17, 10, 500));
            Assert.AreEqual(357, Kata.DutyFree(24, 35, 3000));
        }
    }
}