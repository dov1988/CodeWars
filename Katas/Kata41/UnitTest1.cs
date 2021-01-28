﻿using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Katas.Kata41
{
    //Code as fast as you can! You need to double the integer and return it.

    public static class Kata
    {
        public static int DoubleInteger(int n) => n * 2;
        //{
        //    //Double the input!
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
            public class CodeWarsTest
            {
                private static IEnumerable<TestCaseData> testCases
                {
                    get
                    {
                        yield return new TestCaseData(2).Returns(4);
                        yield return new TestCaseData(4).Returns(8);
                        yield return new TestCaseData(-10).Returns(-20);
                        yield return new TestCaseData(0).Returns(0);
                        yield return new TestCaseData(100).Returns(200);
                    }
                }

                [Test, TestCaseSource("testCases")]
                public int Test(int n) => Kata.DoubleInteger(n);
            }
        }
    }
}
