using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Katas.Kata40
{
    //The code gives an error!
    //Kata.A = 123.ToSTring();
    //Fix it!
    public class Kata
    {
        public static string A { get { return "123"; } }

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
                Assert.AreEqual("123", Kata.A);
            }
        }
    }
}
