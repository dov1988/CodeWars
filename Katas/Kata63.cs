using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Katas.Kata63
{
    //Introduction
    //The wave(known as the Mexican wave in the English-speaking world outside North America) is an example of metachronal rhythm achieved in a packed stadium when successive groups of spectators briefly stand, yell, and raise their arms.Immediately upon stretching to full height, the spectator returns to the usual seated position.
    //The result is a wave of standing spectators that travels through the crowd, even though individual spectators never move away from their seats.In many large arenas the crowd is seated in a contiguous circuit all the way around the sport field, and so the wave is able to travel continuously around the arena; in discontiguous seating arrangements, the wave can instead reflect back and forth through the crowd.When the gap in seating is narrow, the wave can sometimes pass through it.Usually only one wave crest will be present at any given time in an arena, although simultaneous, counter-rotating waves have been produced. (Source Wikipedia)
    //Task
    //In this simple Kata your task is to create a function that turns a string into a Mexican Wave.You will be passed a string and you must return that string in an array where an uppercase letter is a person standing up. 
    //Rules
    // 1.  The input string will always be lower case but maybe empty.
    // 2.  If the character in the string is whitespace then pass over it as if it was an empty seat
    //Example
    //wave("hello") => []string{ "Hello", "hEllo", "heLlo", "helLo", "hellO"}
    public class Kata
    {
        public List<string> wave(string str)
        {
            List<string> list = new List<string>();
            string strWave = "";
            if(str == "")
            {
                return list;
            }
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < str.Length; j++)
                {
                    if(i == j)
                    {
                        strWave += char.ToUpper(str[i]);
                    }
                    else
                    {
                        strWave += str[j];
                    }
                }
                list.Add(strWave);
            }
            return list;
        }
    }

    class UnitTest1
    {
        class KataTestClass
        {
            [TestCase]
            public void BasicTest1()
            {
                Kata kata = new Kata();
                List<string> result = new List<string> { "Hello", "hEllo", "heLlo", "helLo", "hellO" };
                Assert.AreEqual(result, kata.wave("hello"), "it should return '" + result + "'");
            }

            [TestCase]
            public void BasicTest2()
            {
                Kata kata = new Kata();
                List<string> result = new List<string> { "Codewars", "cOdewars", "coDewars", "codEwars", "codeWars", "codewArs", "codewaRs", "codewarS" };
                Assert.AreEqual(result, kata.wave("codewars"), "it should return '" + result + "'");
            }

            [TestCase]
            public void BasicTest3()
            {
                Kata kata = new Kata();
                List<string> result = new List<string> { };
                Assert.AreEqual(result, kata.wave(""), "it should return '" + result + "'");
            }

            [TestCase]
            public void BasicTest4()
            {
                Kata kata = new Kata();
                List<string> result = new List<string> { "Two words", "tWo words", "twO words", "two Words", "two wOrds", "two woRds", "two worDs", "two wordS" };
                Assert.AreEqual(result, kata.wave("two words"), "it should return '" + result + "'");
            }

            [TestCase]
            public void BasicTest5()
            {
                Kata kata = new Kata();
                List<string> result = new List<string> { " Gap ", " gAp ", " gaP " };
                Assert.AreEqual(result, kata.wave(" gap "), "it should return '" + result + "'");
            }

        }
    }
}

