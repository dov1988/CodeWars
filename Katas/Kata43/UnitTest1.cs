using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Linq;

namespace Katas.Kata43
{
//We want an array, but not just any old array, an array with contents!
//Write a function that produces an array with the numbers 0 to N-1 in it.
//For example, the following code will result in an array containing the numbers 0 to 4:
//arr(5) // => [0,1,2,3,4]
    public class Kata
    {
        public static int[] Arr(int N) => Enumerable.Range(0, N).ToArray();
        //{
        //    int[] array = new int[N];
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        array[i] = i;
        //    }
        //    return array;
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

            [TestFixture]
            public class SolutionTest
            {
                [Test, Description("Kata.Arr creates a new array with the numbers 0 to N-1")]
                public void ExampleTest()
                {
                    Assert.IsTrue(Kata.Arr(0).GetType().IsArray, "Kata.Arr creates a new array with the numbers 0 to N-1");
                    Assert.AreEqual(new int[0], Kata.Arr(0), "should return a blank array when called with no argument");
                    Assert.AreEqual(new int[] { 0, 1, 2, 3 }, Kata.Arr(4), "should return 0 to 3 when called with 4");
                }
            }
        }
    }
}
