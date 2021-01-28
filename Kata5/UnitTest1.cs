using NUnit.Framework;

namespace Kata5
{
    //Given 2 strings, a and b, return a string of the form short+long+short, with the shorter string on the 
    //outside and the longer string on the inside.The strings will not be the same length, but they may be empty (length 0 ).
    public class ShortLongShort
    {
        public static string Solution(string a, string b)
        {
            char[] arrayA = a.ToCharArray();
            char[] arrayB = b.ToCharArray();
            if(a.Length > b.Length)
            {
                return b + a + b;
            }
            else
            {
                return a + b + a;
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
        public void BasicTest()
        {
            Assert.AreEqual("1221", ShortLongShort.Solution("1", "22"));
            Assert.AreEqual("1221", ShortLongShort.Solution("22", "1"));
            Assert.AreEqual("12321", ShortLongShort.Solution("232", "1"));
            Assert.AreEqual("232", ShortLongShort.Solution("232", ""));
            Assert.AreEqual("2322132232", ShortLongShort.Solution("232", "2132"));
        }
    }
}