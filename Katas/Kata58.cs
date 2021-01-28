using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Katas.Kata58
{
    //In this Kata, we will calculate the minumum positive number that is not a possible sum from a list of positive integers.
    //solve([1, 2, 8, 7]) = 4 => we can get 1, 2, 3 (from 1+2), but we cannot get 4. 4 is the minimum number not possible from the list. 
    //solve([4, 1, 2, 3, 12]) = 11.We can get 1, 2, 3, 4, 4 + 1 = 5, 4 + 2 = 6,4 + 3 = 7,4 + 3 + 1 = 8,4 + 3 + 2 = 9,4 + 3 + 2 + 1 = 10.But not 11.
    //solve([2, 3, 2, 3, 4, 2, 12, 3]) = 1.We cannot get 1.


    public class Solution
    {
        public static bool FindSumEqualToNumber(int number, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != 0 && arr[i] + arr[i + 1] != number)
                {

                }
            }
            return true;
        }
        public static int solve(int[] arr)
        {
            Array.Sort(arr);

            return 0;
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
                    Assert.AreEqual(4, Solution.solve(new int[] { 1, 2, 8, 7 }));
                    Assert.AreEqual(7, Solution.solve(new int[] { 2, 12, 3, 1 }));
                    Assert.AreEqual(19, Solution.solve(new int[] { 4, 2, 8, 3, 1 }));
                    Assert.AreEqual(1, Solution.solve(new int[] { 4, 2, 12, 3 }));
                    Assert.AreEqual(8, Solution.solve(new int[] { 1, 2, 4 }));
                }
            }
        }
    }

