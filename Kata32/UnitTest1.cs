using NUnit.Framework;
using System;
using System.Linq;
namespace Kata32
{
//Create a function called that accepts 2 string arguments and returns an integer of the count of occurrences the 2nd argument is found in the first one.
//If no occurrences can be found, a count of 0 should be returned.
//strCount('Hello', 'o') // => 1
//strCount('Hello', 'l') // => 2
//strCount('', 'z')      // => 0
//Notes:
//The first argument can be an empty string
//The second string argument will always be of length 1

    class Kata
    {
        public static int StrCount(string str, string letter) => str.Count(x => x.ToString() == letter);
        //{
        //    int count = 0;
        //    char [] c = letter.ToCharArray();
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if(str[i] == c[0])
        //        {
        //            count += 1;
        //        }
        //    }
        //    return count;
        //}
    }
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestFixture]
        class Tets
        {
            [TestCase("Hello", "o", 1)]
            [TestCase("Hello", "l", 2)]
            [TestCase("", "z", 0)]
            public void BasicTetst(string a, string b, int expected)
            {
                Assert.That(Kata.StrCount(a, b), Is.EqualTo(expected));
            }
        }
    }
}