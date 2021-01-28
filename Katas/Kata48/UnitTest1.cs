using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using NUnit.Framework;
using System.Linq;

namespace Katas.Kata48
{
    //Your team is writing a fancy new text editor and you've been tasked with implementing the line numbering.
    //Write a function which takes a list of strings and returns each line prepended by the correct number.
    //The numbering starts at 1. The format is n: string. Notice the colon and space in between.
    //Examples:
    //number(List<string>()) // => List<string>()
    //number(List<string>{ "a", "b", "c"}) // => ["1: a", "2: b", "3: c"]
    public class LineNumbering
    {
        public static List<string> Number(List<string> lines) => lines.Select((x, i) => $"{i + 1}: {x}").ToList();
        //{
        //    List<string> numberedLines = new List<string>();
        //    int number = 1;
        //    foreach (string str in lines)
        //    {
        //        numberedLines.Add($"{number}" + ": " + str);
        //        number++;
        //    }
        //    return numberedLines;
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

            [TestCase]
            public void basicTests()
            {
                Assert.AreEqual(new List<string>(), LineNumbering.Number(new List<string>()));
                Assert.AreEqual(new List<string> { "1: a", "2: b", "3: c" }, LineNumbering.Number(new List<string> { "a", "b", "c" }));
                Assert.AreEqual(new List<string> { "1: ", "2: ", "3: ", "4: ", "5: " }, LineNumbering.Number(new List<string> { "", "", "", "", "" }));
            }
        }
    }
}
