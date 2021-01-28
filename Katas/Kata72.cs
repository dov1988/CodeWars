using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Katas.Kata72
{
//Let us consider this example (array written in general format):
//ls = [0, 1, 3, 6, 10]
//Its following parts:
//ls = [0, 1, 3, 6, 10]
//ls = [1, 3, 6, 10]
//ls = [3, 6, 10]
//ls = [6, 10]
//ls = [10]
//ls = []
//The corresponding sums are (put together in a list): [20, 20, 19, 16, 10, 0]
//The function parts_sums (or its variants in other languages) will take as parameter a list ls and return a list of the sums of its parts as defined above.
//Other Examples:
//ls = [1, 2, 3, 4, 5, 6]
//parts_sums(ls) -> [21, 20, 18, 15, 11, 6, 0]
//ls = [744125, 935, 407, 454, 430, 90, 144, 6710213, 889, 810, 2579358]
//parts_sums(ls) -> [10037855, 9293730, 9292795, 9292388, 9291934, 9291504, 9291414, 9291270, 2581057, 2580168, 2579358, 0]
//Notes
//Some lists can be long.
//Please ask before translating: some translations are already written and published when/if the kata is approved.
    class SumParts
    {
        public static int[] PartsSums(int[] ls)
        {
            int[] result = new int[ls.Length + 1];
            int totalSum = ls.Sum();
            int subtrahend = 0;
            result[0] = totalSum;
            for (int i = 0; i < ls.Length - 1; i++)
            {
                subtrahend += ls[i];
                for (int j = 1; j < result.Length; j++)
                {
                    result[j] = totalSum - subtrahend;
                }
            }
            result[result.Length - 1] = 0;
            return result;
        }
    }


    [TestFixture]
    public static class SumPartsTests
    {
        private static void dotest(int[] ls, int[] exp)
        {
            int[] ans = SumParts.PartsSums(ls);
            Assert.AreEqual(exp, ans);
        }
        [Test]
        public static void atest0()
        {
            Console.WriteLine("Basic Tests");
            dotest(new int[] { }, new int[] { 0 });
            dotest(new int[] { 0, 1, 3, 6, 10 }, new int[] { 20, 20, 19, 16, 10, 0 });
            dotest(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 21, 20, 18, 15, 11, 6, 0 });
            dotest(new int[] { 744125, 935, 407, 454, 430, 90, 144, 6710213, 889, 810, 2579358 },
                    new int[] { 10037855, 9293730, 9292795, 9292388, 9291934, 9291504, 9291414, 9291270, 2581057, 2580168, 2579358, 0 });

        }
    }
}

