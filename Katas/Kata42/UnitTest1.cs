using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Katas.Kata42
{
//One hot summer day Pete and his friend Billy decided to buy watermelons.They chose the biggest crate.They rushed home, dying of thirst, and decided to divide their loot, however they faced a hard problem.
//Pete and Billy are great fans of even numbers, that's why they want to divide the number of watermelons in such a way that each of the two parts consists of an even number of watermelons. However, it is not obligatory that the parts are equal.
//Example: the boys can divide a stack of 8 watermelons into 2+6 melons, or 4+4 melons.
//The boys are extremely tired and want to start their meal as soon as possible, that's why you should help them and find out, whether they can divide the fruits in the way they want. For sure, each of them should get a part of positive weight.
//Task
//Given an integral number of watermelons w(1 ≤ w ≤ 100; 1 ≤ w in Haskell), check whether Pete and Billy can divide the melons so that each of them gets an even amount.
//Examples
//Watermelon.divide(2) == false // 2 = 1 + 1
//Watermelon.divide(3) == false // 3 = 1 + 2
//Watermelon.divide(4) == true  // 4 = 2 + 2
//Watermelon.divide(5) == false // 5 = 2 + 3
//Watermelon.divide(6) == true  // 6 = 2 + 4

    public class Watermelon
    {
        public static bool Divide(int weight) => (weight - 2) % 2 == 0 && weight > 2;
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
            public void Test1()
            {
                Assert.AreEqual(true, Watermelon.Divide(4));
            }

            [Test]
            public void Test2()
            {
                Assert.AreEqual(false, Watermelon.Divide(2));
            }

            [Test]
            public void Test3()
            {
                Assert.AreEqual(false, Watermelon.Divide(5));
            }

            [Test]
            public void Test4()
            {
                Assert.AreEqual(true, Watermelon.Divide(88));
            }

            [Test]
            public void Test5()
            {
                Assert.AreEqual(true, Watermelon.Divide(100));
            }

            [Test]
            public void Test6()
            {
                Assert.AreEqual(false, Watermelon.Divide(67));
            }

            [Test]
            public void Test7()
            {
                Assert.AreEqual(true, Watermelon.Divide(90));
            }

            [Test]
            public void Test8()
            {
                Assert.AreEqual(true, Watermelon.Divide(10));
            }

            [Test]
            public void Test9()
            {
                Assert.AreEqual(false, Watermelon.Divide(99));
            }

            [Test]
            public void Test10()
            {
                Assert.AreEqual(true, Watermelon.Divide(32));
            }
        }
    }
}
