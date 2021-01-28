using NUnit.Framework;
using System;
using System.Linq;

namespace Kata30
{
//Create an extension method IsUpperCase to see whether the string is ALL CAPS.For example:
//"c".IsUpperCase() == false
//"C".IsUpperCase() == true
//"hello I AM DONALD".IsUpperCase() == false
//"HELLO I AM DONALD".IsUpperCase() == true
//"ACSKLDFJSgSKLDFJSKLDFJ".IsUpperCase() == false
//"ACSKLDFJSGSKLDFJSKLDFJ".IsUpperCase() == true
//In this Kata, a string is said to be in ALL CAPS whenever it does not contain any lowercase letter so any string containing no letters at all is trivially considered to be in ALL CAPS.
    public static class StringExtensions
    {
        public static bool IsUpperCase(this string text)
        {
            return text.ToUpper() == text;
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (char.IsLower(text[i]))
            //    {
            //            return false;
            //    }
            //}
            //return true;
        }
    }
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("c", ExpectedResult = false)]
        [TestCase("C", ExpectedResult = true)]
        [TestCase("hello I AM DONALD", ExpectedResult = false)]
        [TestCase("HELLO I AM DONALD", ExpectedResult = true)]
        [TestCase("ACSKLDFJSgSKLDFJSKLDFJ", ExpectedResult = false)]
        [TestCase("ACSKLDFJSGSKLDFJSKLDFJ", ExpectedResult = true)]
        public static bool FixedTest(string text)
        {
            return text.IsUpperCase();
        }
    }
}