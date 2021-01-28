using NUnit.Framework;
using System;

namespace Kata23
{
//Clock shows 'h' hours, 'm' minutes and 's' seconds after midnight.
//Your task is to make 'Past' function which returns time converted to milliseconds.
//Example:
//Past(0, 1, 1) == 61000
//Input constraints: 0 <= h <= 23, 0 <= m <= 59, 0 <= s <= 59
    public static class Clock
    {
        public static int Past(int h, int m, int s)
        {
            int milliseconds = (int)new TimeSpan(h, m, s).TotalMilliseconds;
            return milliseconds;
        }
    }

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test()
        {
            Assert.AreEqual(61000, Clock.Past(0, 1, 1));
        }
    }
}