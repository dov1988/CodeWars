using NUnit.Framework;
using System;

namespace Kata8
{
    //Write function parseFloat which takes an input and returns a number or Nothing if conversion is not possible.

    public class Kata
    {
        public static double? ParseF(object s = null)
        {
            if (s is byte)
            {
                return (double)((byte)s);
            }

            else if (s is sbyte)
            {
                return (double)((sbyte)s);
            }
            else if (s is short)
            {
                return (double)((short)s);
            }
            else if (s is ushort)
            {
                return (double)((ushort)s);
            }
            else if (s is int)
            {
                return (double)((int)s);
            }
            else if (s is uint)
            {
                return (double)((uint)s);
            }
            else if (s is long)
            {
                return (double)((long)s);
            }
            else if (s is ulong)
            {
                return (double)((ulong)s);
            }
            else if (s is decimal)
            {
                return (double)((decimal)s);
            }
            else if (s is double)
            {
                return (double)s;
            }
            else if (s is float)
            {
                return (double)((float)s);
            }
            else if (s is char)
            {
                return (double)((char)s);
            }
            else if (s is string)
            {
                double result;
                string str = (string)s;
                if (double.TryParse(str, out result))
                {
                    return double.Parse(str);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(1.0d, Kata.ParseF("1"));
        }
    }
}