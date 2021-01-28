using NUnit.Framework;
using System;

namespace Kata7
{
// The cockroach is one of the fastest insects. Write a function which 
// takes its speed in km per hour and returns it in cm per second, rounded down to the integer (= floored).
//For example:
//CockroachSpeed(1.08) == 30
// Note! The input is a Real number (actual type is language dependent) and is >= 0. The result should be an Integer.
    public class Cockroach
    {
        public static int CockroachSpeed(double x)
        {
            return (int)(Math.Floor(x/0.036));
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
            Assert.AreEqual(30, Cockroach.CockroachSpeed(1.08));
            Assert.AreEqual(30, Cockroach.CockroachSpeed(1.09));
            Assert.AreEqual(0, Cockroach.CockroachSpeed(0));
        }
    }
}