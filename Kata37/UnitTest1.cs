using NUnit.Framework;
using System.Linq;
using System;

namespace Kata37
{
    //At the annual family gathering, the family likes to find the oldest living family member’s age and the youngest family 
    //member’s age and calculate the difference between them.
    //You will be given an array of all the family members' ages, in any order. The ages will be given in whole numbers, so a baby 
    //of 5 months, will have an ascribed ‘age’ of 0. Return a new array (a tuple in Python) with [youngest age, oldest age, 
    //difference between the youngest and oldest age].
    public class Kata
    {
        public static int[] DifferenceInAges(int[] ages) => new int[] { ages.Min(), ages.Max(), ages.Max() - ages.Min() };
        //{

        //}
    }
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestFixture]
        public class SolutionTest
        {
            [Test, Description("Should return expected results for sample tests")]
            public void SampleTest()
            {
                Assert.AreEqual(new int[] { 6, 82, 76 }, Kata.DifferenceInAges(new int[] { 82, 15, 6, 38, 35 }));
                Assert.AreEqual(new int[] { 14, 99, 85 }, Kata.DifferenceInAges(new int[] { 57, 99, 14, 32 }));
            }
        }
    }
}