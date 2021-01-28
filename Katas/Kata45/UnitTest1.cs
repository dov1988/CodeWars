using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Katas.Kata45
{
    //Bob needs a fast way to calculate the volume of a cuboid with three values: length, width and the height of the cuboid.
    //Write a function to help Bob with this calculation.
    public class Kata
    {
        public static double getVolumeOfCubiod(double length, double width, double height) => length * width * height;
        //{
            
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

            [Test]
            public void Test()
            {
                Assert.AreEqual(4, Kata.getVolumeOfCubiod(1, 2, 2));
                Assert.AreEqual(63, Kata.getVolumeOfCubiod(6.3, 2, 5));
            }
        }
    }
}
