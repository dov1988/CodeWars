using NUnit.Framework;
using System;
using System.Linq;

namespace Kata31
{
//Given two integer arrays a, b, both of length >= 1, create a program that returns true if the sum of the squares of each element in a is strictly greater than the sum of the cubes of each element in b.
//E.g.
//Kata.ArrayMadness(new int[] {4, 5, 6}, new int[] {1, 2, 3}) => true // because 4 ** 2 + 5 ** 2 + 6 ** 2 > 1 ** 3 + 2 ** 3 + 3 ** 3
//Get your timer out. Are you ready? Ready, get set, GO!!!
    public class Kata
    {
        public static bool ArrayMadness(int[] a, int[] b) => a.Sum(x => x * x) > b.Sum(x => x * x * x);
        //{
        //    int sumA = 0;
        //    int sumB = 0;
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        sumA += a[i] * a[i];
        //    }
        //    for (int i = 0; i < b.Length; i++)
        //    {
        //        sumB += b[i] * b[i] * b[i];
        //    }
        //    if(sumA > sumB)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
    }
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, Description("Should work for sample tests")]
        public void SampleTest()
        {
            Assert.AreEqual(true, Kata.ArrayMadness(new int[] { 4, 5, 6 }, new int[] { 1, 2, 3 }));
            Assert.AreEqual(false, Kata.ArrayMadness(new int[] { 5, 6, 7 }, new int[] { 4, 5, 6 }));
        }
    }
}