using NUnit.Framework;
using System.Linq;

namespace Kata25
{
//I'm new to coding and now I want to get the sum of two arrays...actually the sum of all their elements. I'll appreciate for your help.
//P.S.Each array includes only integer numbers.Output is a number too.
    public static class Kata
    {
        public static int ArrayPlusArray(int[] arr1, int[] arr2)
        {
            return arr1.Sum() + arr2.Sum();
        }
    }
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(21, Kata.ArrayPlusArray(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }));
            Assert.AreEqual(-21, Kata.ArrayPlusArray(new int[] { -1, -2, -3 }, new int[] { -4, -5, -6 }));
            Assert.AreEqual(15, Kata.ArrayPlusArray(new int[] { 0, 0, 0 }, new int[] { 4, 5, 6 }));
            Assert.AreEqual(2100, Kata.ArrayPlusArray(new int[] { 100, 200, 300 }, new int[] { 400, 500, 600 }));

        }
    }
}