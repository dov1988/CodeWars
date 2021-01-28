using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Katas.Kata56
{
    //In this Kata, you will be given a string that may have mixed uppercase and lowercase letters and your task is to convert that string to either lowercase only or uppercase only based on:
    //make as few changes as possible.
    //if the string contains equal number of uppercase and lowercase letters, convert the string to lowercase.

    class Kata
    {
        public static string Solve(string s) => s.Count(char.IsLower) >= s.Count(char.IsUpper) ? s.ToLower() : s.ToUpper();
        //{
            //int lower = 0;
            //int upper = 0;
            //foreach (char item in s)
            //{
            //    if (char.IsUpper(item))
            //    {
            //        upper++;
            //    }
            //    else
            //    {
            //        lower++;
            //    }
            //}
            //if(upper > lower)
            //{
            //   return s.ToUpper();
            //}
            //return s.ToLower();
        //}
    }
    class UnitTest1
    {
        public class Tests
        {
            [SetUp]
            public void Setup()
            {
            }

            [TestCase("code", "code")]
            [TestCase("CODe", "CODE")]
            [TestCase("COde", "code")]
            [TestCase("Code", "code")]
            public void BasicTests(string s, string expected)
            {
                Assert.That(Kata.Solve(s), Is.EqualTo(expected));
            }
        }
    }
}

