using NUnit.Framework;
using System;

namespace Kata29
{
//Define String.prototype.toAlternatingCase(or a similar function/method such as to_alternating_case/toAlternatingCase/ToAlternatingCase in your selected language; see the initial solution for details) such that each lowercase letter becomes uppercase and each uppercase letter becomes lowercase.For example:
//"hello world".ToAlternatingCase() == "HELLO WORLD"
//"HELLO WORLD".ToAlternatingCase() == "hello world"
//"hello WORLD".ToAlternatingCase() == "HELLO world"
//"HeLLo WoRLD".ToAlternatingCase() == "hEllO wOrld"
//"12345".ToAlternatingCase() == "12345" // Non-alphabetical characters are unaffected
//"1a2b3c4d5e".ToAlternatingCase() == "1A2B3C4D5E"
//"String.ToAlternatingCase".ToAlternatingCase() == "sTRING.tOaLTERNATINGcASE"
//As usual, your function/method should be pure, i.e.it should not mutate the original string.

        public static class StringExt
        {
            public static string ToAlternatingCase(this string s)
            {
                string result = "";
                foreach (char item in s)
                {
                    if (char.IsUpper(item))
                    {
                        result += char.ToLower(item);
                    }
                    else if (char.IsLower(item))
                    {
                        result += char.ToUpper(item);
                    }
                    else
                    {
                        result += item;
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
        public void Examples()
        {
            Assert.AreEqual("HELLO WORLD", "hello world".ToAlternatingCase());
            Assert.AreEqual("hello world", "HELLO WORLD".ToAlternatingCase());
            Assert.AreEqual("HELLO world", "hello WORLD".ToAlternatingCase());
            Assert.AreEqual("hEllO wOrld", "HeLLo WoRLD".ToAlternatingCase());
            Assert.AreEqual("12345", "12345".ToAlternatingCase());
            Assert.AreEqual("1A2B3C4D5E", "1a2b3c4d5e".ToAlternatingCase());
            Assert.AreEqual("sTRING.tOaLTERNATINGcASE", "String.ToAlternatingCase".ToAlternatingCase());
            Assert.AreEqual("Hello World", "Hello World".ToAlternatingCase().ToAlternatingCase(), "Hello World => hELLO wORLD => Hello World");
        }
    }
}