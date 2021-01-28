using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Katas.Kata60
{
    //For a given string s find the character c(or C) with longest consecutive repetition and return:
    //Tuple<char?, int>(c, l)
    //where l(or L) is the length of the repetition.If there are two or more characters with the same l return the first in order of appearance.
    //For empty string return:
    //Tuple<char?, int>(null, 0)

    public static class Kata
    {
        public static Tuple<char?, int> LongestRepetition(string input)
        {
            int countTemp = 1;
            int countResult = 0;
            char? charResult = null;
            for (int i = 0; i < input.Length; i++)
            {
                if (i != input.Length - 1 && input[i] == input[i + 1])
                {
                    countTemp++;
                }
                else
                {
                    if (countResult < countTemp)
                    {
                        countResult = countTemp;
                        charResult = input[i];
                    }
                    countTemp = 1;
                }
            }
            return new Tuple<char?, int>(charResult, countResult);
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

            [Test]
            public void LongestAtTheBeginning()
            {
                Assert.AreEqual(new Tuple<char?, int>('a', 4), Kata.LongestRepetition("aaaabb"));
                Assert.AreEqual(new Tuple<char?, int>('b', 5), Kata.LongestRepetition("abbbbb"));
            }

            [Test]
            public void LongestAtTheEnd()
            {
                Assert.AreEqual(new Tuple<char?, int>('a', 4), Kata.LongestRepetition("bbbaaabaaaa"));
            }

            [Test]
            public void LongestInTheMiddle()
            {
                Assert.AreEqual(new Tuple<char?, int>('u', 3), Kata.LongestRepetition("cbdeuuu900"));
            }

            [Test]
            public void MultipleLongest()
            {
                Assert.AreEqual(new Tuple<char?, int>('a', 2), Kata.LongestRepetition("aabb"));
                Assert.AreEqual(new Tuple<char?, int>('b', 1), Kata.LongestRepetition("ba"));
            }

            [Test]
            public void EmptyString()
            {
                Assert.AreEqual(new Tuple<char?, int>(null, 0), Kata.LongestRepetition(""));
            }
        }
    }
}

