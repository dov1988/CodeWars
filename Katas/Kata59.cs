using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Katas.Kata59
{
    //In this Kata, you will be given an array of strings and your task is to remove all consecutive duplicate letters from each string in the array.
    //For example:
    //dup(["abracadabra", "allottee", "assessee"]) = ["abracadabra", "alote", "asese"].
    //dup(["kelless", "keenness"]) = ["keles","kenes"].
    //Strings will be lowercase only, no spaces. See test cases for more examples.


    public class Solution
    {

        public static string[] dup(string[] arr)
        {
            string[] result = new string[arr.Length];
            StringBuilder stringBuilder = new StringBuilder();
            for (int j = 0; j < arr.Length; j++)
            {
                for (int i = 0; i < arr[j].Length; i++)
                {
                    if (i != 0 && arr[j][i] == arr[j][i - 1])
                    {
                        continue;
                    }
                    else
                    {
                        stringBuilder.Append(arr[j][i]);
                    }
                }
                result[j] = stringBuilder.ToString();
                stringBuilder.Clear();
            }
            return result;
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
            public void ExampleTests()
            {
                Assert.AreEqual(new String[] { "codewars", "picaniny", "hubububo" }, Solution.dup(new String[] { "ccooddddddewwwaaaaarrrrsssss", "piccaninny", "hubbubbubboo" }));
                Assert.AreEqual(new String[] { "abracadabra", "alote", "asese" }, Solution.dup(new String[] { "abracadabra", "allottee", "assessee" }));
                Assert.AreEqual(new String[] { "keles", "kenes" }, Solution.dup(new String[] { "kelless", "keenness" }));

            }
        }
    }
}

