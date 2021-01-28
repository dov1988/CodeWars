using NUnit.Framework;
using System;

namespace Kata2
{
    public static class Kata
    {
        public static string AlphabetPosition(string text)
        {
            char [] array = text.ToCharArray();
            int a = 'a';
            int number = a - 1;
            string str = "";
            for (int i = 0; i < array.Length; i++)
            {
                if (Char.IsLetter(array[i]))
                {
                   int alphabetPosition = Char.ToLower(array[i]) - number;
                    if (str != "")
                    {
                        str += " " +  alphabetPosition.ToString();
                    }
                    else
                    {
                        str += alphabetPosition.ToString();
                    }
                }
            }
            return str;
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
            Assert.AreEqual("20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11", Kata.AlphabetPosition("The sunset sets at twelve o' clock."));
            Assert.AreEqual("20 8 5 14 1 18 23 8 1 12 2 1 3 15 14 19 1 20 13 9 4 14 9 7 8 20", Kata.AlphabetPosition("The narwhal bacons at midnight."));
        }
    }
}