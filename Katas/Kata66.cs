using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Katas.Kata66
{
//Assume "#" is like a backspace in string. This means that string "a#bc#d" actually is "bd"
//Your task is to process a string with "#" symbols.
//Examples
//"abc#d##c"      ==>  "ac"
//"abc##d######"  ==>  ""
//"#######"       ==>  ""
//""              ==>  ""

    public class Kata
    {
        public static string CleanString(string s)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != '#')
                {
                    stringBuilder.Append(s[i]);
                }
                else
                {
                    if (stringBuilder.Length > 0)
                    {
                        stringBuilder.Remove(stringBuilder.Length - 1, 1);
                    }
                }
            }
            return stringBuilder.ToString();
        }
    }

    class UnitTest1
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("ac", Kata.CleanString("abc#d##c"));
            Assert.AreEqual("", Kata.CleanString("abc####d##c#"));
        }
    }
}

