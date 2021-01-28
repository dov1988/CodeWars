using NUnit.Framework;

namespace Kata24
{
    //Write a function to convert a name into initials.This kata strictly takes two words with one space in between them.
    //The output should be two capital letters with a dot separating them.
    //It should look like this:
    //Sam Harris => S.H
    //Patrick Feeney => P.F
    public class Kata
    {
        public static string AbbrevName(string name)
        {
            return name[0].ToString().ToUpper() + "." + name[name.IndexOf(" ", 0) + 1].ToString().ToUpper();
            //string abbrevName = name[0].ToString().ToUpper();
            //for (int i = 0; i < name.Length; i++)
            //{
            //    if (char.IsWhiteSpace(name[i]))
            //    {
            //        abbrevName += "." + name[i + 1].ToString().ToUpper();
            //    }
            //}
            //return abbrevName;
        }
    }
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("S.H", Kata.AbbrevName("Sam Harris"));
            Assert.AreEqual("P.F", Kata.AbbrevName("Patrick Feenan"));
            Assert.AreEqual("E.C", Kata.AbbrevName("Evan Cole"));
            Assert.AreEqual("P.F", Kata.AbbrevName("P Favuzzi"));
            Assert.AreEqual("D.M", Kata.AbbrevName("David Mendieta"));
        }
    }
}