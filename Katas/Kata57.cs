using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Katas.Kata57
{
    //In this Kata, you will be given a string and two indexes (a and b). Your task is to reverse the portion of that string between those two indices inclusive.
    //solve("codewars",1,5) = "cawedors" -- elements at index 1 to 5 inclusive are "odewa". So we reverse them.
    //solve("cODEWArs", 1,5) = "cAWEDOrs" -- to help visualize.
    //Input will be lowercase and uppercase letters only.
    //The first index a will always be lower that than the string length; the second index b can be greater than the string length. More examples in the test cases. Good luck!

    public class Solution
    {
        public static String solve(String s, int a, int b)
        {
            char[] array = s.ToCharArray();
            if (b < array.Length - 1)
            {
                Array.Reverse(array, a, b - a + 1);
            }
            else
            {
                Array.Reverse(array, a, array.Length - a);
            }
            return string.Concat<char>(array);
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
                Assert.AreEqual("cawedors", Solution.solve("codewars", 1, 5));
                Assert.AreEqual("conuFsIgnid", Solution.solve("codingIsFun", 2, 100));
                Assert.AreEqual("FuargorPlanoitcnmming", Solution.solve("FunctionalProgramming", 2, 15));
                Assert.AreEqual("vutsrqponmlkjihgfecbawxyz", Solution.solve("abcefghijklmnopqrstuvwxyz", 0, 20));
                Assert.AreEqual("abcefvutsrqponmlkjihgwxyz", Solution.solve("abcefghijklmnopqrstuvwxyz", 5, 20));

            }
        }
    }
}

