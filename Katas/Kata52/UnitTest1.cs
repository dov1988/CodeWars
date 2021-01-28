using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Katas.Kata52
{
    //In this Kata, you will be given directions and your task will be to find your way back.
    //solve(["Begin on Road A", "Right on Road B", "Right on Road C", "Left on Road D"]) = ['Begin on Road D', 'Right on Road C', 'Left on Road B', 'Left on Road A']
    //solve(['Begin on Lua Pkwy', 'Right on Sixth Alley', 'Right on 1st Cr']) =  ['Begin on 1st Cr', 'Left on Sixth Alley', 'Left on Lua Pkwy']
    public class Solution
    {
        public static string[] solve(string[] arr)
        {
            string[] result = new string[arr.Length];
            Array.Reverse(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (i == 0 && arr[i][j] == ' ')
                    {
                        result[i] = "Begin" + arr[i].Substring(j);
                        break;
                    }
                    else if (i > 0 && i < arr.Length && arr[i][j] == ' ')
                    {
                        if (arr[i - 1][0] == 'L')
                        {
                            result[i] = "Right" + arr[i].Substring(j);
                        }
                        else
                        {
                            result[i] = "Left" + arr[i].Substring(j);
                        }
                        break;
                    }
                }

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
                Assert.AreEqual(new String[] { "Begin on Road D", "Right on Road C", "Left on Road B", "Left on Road A" }, Solution.solve(new String[] { "Begin on Road A", "Right on Road B", "Right on Road C", "Left on Road D" }));
                Assert.AreEqual(new String[] { "Begin on 9th Dr", "Right on First Road", "Left on 3rd Blvd" }, Solution.solve(new String[] { "Begin on 3rd Blvd", "Right on First Road", "Left on 9th Dr" }));
                Assert.AreEqual(new String[] { "Begin on Road A" }, Solution.solve(new String[] { "Begin on Road A" }));

            }
        }
    }
}

