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

namespace Katas.Kata74
{
    class AreTheySame
    {
        public static bool comp(int[] a, int[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if(Math.Pow(a[i],2) == b[j])
                    {
                        if(j == b.Length - 1 && i == a.Length - 1)
                        {
                            return true;
                        }
                        break;
                    }
                    else if(j == b.Length - 1)
                    {
                        return false;
                    }
                }
            }
            throw new Exception("Входные параметры не являются корректными для данной задачи.");
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

            [TestFixture]
            public class AreTheySameTests
            {

                [Test]
                public void Test1()
                {
                    int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
                    int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
                    bool r = AreTheySame.comp(a, b); // True
                    Assert.AreEqual(true, r);
                }
            }
        }
    }
}
