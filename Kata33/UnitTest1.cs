using NUnit.Framework;

namespace Kata33
{
    //In this kata you are required to, given a string, replace every letter with its position in the alphabet.
    //If anything in the text isn't a letter, ignore it and don't return it.
    //"a" = 1, "b" = 2, etc.
    //Example
    //Kata.AlphabetPosition("The sunset sets at twelve o' clock.")
    //Should return "20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11" (as a string)

    public static class Kata
    {
        public static string AlphabetPosition(string text)
        {
            int number = 'a' - 1;
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    if (result == "")
                    {
                        result += char.ToLower(text[i]) - number;
                    }
                    else
                    {
                        result += "" + (char.ToLower(text[i]) - number);
                    }
                }
            }
            return result;
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