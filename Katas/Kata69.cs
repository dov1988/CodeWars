using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Katas.Kata69
{
    //In this Kata, you will be given a string of numbers in sequence and your task will be to return the missing number.If there is no number missing or there is an error in the sequence, return -1.
    //For example:
    //missing("123567") = 4 
    //missing("899091939495") = 92
    //missing("9899101102") = 100
    //missing("599600601602") = -1 -- no number missing
    //missing("8990919395") = -1 -- error in sequence. Both 92 and 94 missing.
    public class Solution
    {
        public static int missing(string s)
        {
            int number = 0;
            int result = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (i <= 9)
                {
                    for (int j = 0; j < s.Length; j++)
                    {
                        number = Convert.ToInt32(s.Substring(j, i)) + 1;
                        if (j != s.Length - i && s.Substring(j + i).StartsWith(number.ToString()))
                        {
                            j += i - 1;
                            if (number.ToString().Length > i)
                            {
                                i++;
                            }
                            continue;
                        }
                        else if (j != s.Length - i && s.Substring(j + i).StartsWith((number + 1).ToString()))
                        {
                            if (result != 0 && (result.ToString().Length == number.ToString().Length || result.ToString().Length == number.ToString().Length - 1))
                            {
                                return -1;
                            }
                            j += i - 1;
                            if ((number + 1).ToString().Length > i)
                            {
                                i++;
                            }
                            result = number;
                        }
                        else if (j == s.Length - i)
                        {
                            if (result != 0 && (result.ToString().Length == number.ToString().Length || result.ToString().Length == number.ToString().Length - 1))
                            {
                                return result;
                            }
                            break;
                        }
                        else { break; }
                    }
                }
                else { return -1; }
            }
            return -1;
        }
    }

    class UnitTest1
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(4, Solution.missing("123567"));
            Assert.AreEqual(92, Solution.missing("899091939495"));
            Assert.AreEqual(100, Solution.missing("9899101102"));
            Assert.AreEqual(-1, Solution.missing("599600601602"));
            Assert.AreEqual(-1, Solution.missing("8990919395"));
            Assert.AreEqual(1002, Solution.missing("998999100010011003"));
            Assert.AreEqual(10000, Solution.missing("99991000110002"));
            Assert.AreEqual(-1, Solution.missing("979899100101102"));
            Assert.AreEqual(900003, Solution.missing("900001900002900004900005900006"));

        }
    }
}

