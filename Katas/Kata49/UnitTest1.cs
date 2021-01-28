using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Katas.Kata49
{
//Given a mathematical equation that has *,+,-,/, reverse it as follows:
//Solve("100*b/y") = "y/b*100"
//Solve("a+b-c/d*30") = "30*d/c-b+a"
    public class Solution
    {
        public static string Solve(string eq)
        {

            string zero = "";
            string number = "";
            string result = "";
            for (int i = eq.Length - 1; i > -1; i--)
            {
                if (char.IsDigit(eq[i]))
                {
                    if (eq[i] != '0')
                    {
                        number = eq[i] + number;
                        if (zero != "")
                        {
                            number += zero;
                            result += number;
                            zero = "";
                            number = "";
                        }
                        else if (i == 0 || (i != 0 && !(char.IsDigit(eq[i - 1]))))
                        {
                            result += number;
                            number = "";
                        }
                    }

                    else if (eq[i] == '0')
                    {
                        if (i != eq.Length - 1 && !(char.IsDigit(eq[i + 1])))
                        {
                            zero += eq[i];
                        }
                        else if (i == eq.Length - 1)
                        {
                            zero += eq[i];
                        }
                        else if (i != eq.Length - 1 && eq[i + 1] == '0')
                        {
                            zero += eq[i];
                        }
                    }
                }

                else
                {
                    result += eq[i];
                }
            }
            return result;
            //Переставляет местами все числа, кроме круглых (10, 100, 1000).
            //string number = "";
            //string result = "";
            //for (int i = eq.Length - 1; i > -1; i--)
            //{
            //    if (char.IsDigit(eq[i]))
            //    {
            //        if (eq[i] != '0')
            //        {
            //            result += eq[i];
            //            if (number != "")
            //            {
            //                result += number;
            //                number = "";
            //            }
            //        }
            //        else if (eq[i] == '0')
            //        {
            //            if (i != eq.Length - 1 && !(char.IsDigit(eq[i + 1])))
            //            {
            //                number += eq[i];
            //            }
            //            else if (i == eq.Length - 1)
            //            {
            //                number += eq[i];
            //            }
            //            else if (i != eq.Length - 1 && eq[i + 1] == '0')
            //            {
            //                number += eq[i];
            //            }
            //        }

            //    }
            //    else
            //    {
            //        result += eq[i];
            //    }
            //}
            //return result;
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
                Assert.AreEqual("y/b*100", Solution.Solve("100*b/y"));
                Assert.AreEqual("30*d/c-b+a", Solution.Solve("a+b-c/d*30"));
                Assert.AreEqual("50+c/b*a", Solution.Solve("a*b/c+50"));
            }
        }
    }
}
