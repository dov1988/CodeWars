using NUnit.Framework;
using System;

namespace Kata9
{
    // Nathan loves cycling.
    //Because Nathan knows it is important to stay hydrated, he drinks 0.5 litres of water per hour of cycling.
    //You get given the time in hours and you need to return the number of litres Nathan will drink, rounded to the smallest value.
    public class Kata
    {
        public static int Litres(double time)
        {
            int litres = (int)(Math.Floor(time * 0.5));
            return litres;
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
            Assert.Pass();
        }
    }
}