using NUnit.Framework;

namespace Kata14
{
    //Create a function that checks if a number n is divisible by two numbers x AND y.All inputs are positive, non-zero digits.


    public class DivisibleNb
    {
        public static bool isDivisible(long n, long x, long y)
        {
            return n % x == 0 && n % y == 0;
        }
    }
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(true, DivisibleNb.isDivisible(12, 4, 3));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(false, DivisibleNb.isDivisible(3, 3, 4));
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual(false, DivisibleNb.isDivisible(8, 3, 4));
        }
    }
}