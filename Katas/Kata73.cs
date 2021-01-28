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

namespace Katas.Kata73
{
//John wants to decorate a room with wallpaper.He wants a fool-proof method for getting it right.
//John knows that the rectangular room has a length of l meters, a width of w meters, a height of h meters.The standard width 
//of the rolls he wants to buy is 52 centimeters.The length of a roll is 10 meters.He bears in mind however, that it’s best to 
//have an extra length of wallpaper handy in case of mistakes or miscalculations so he wants to buy a length 15% greater than 
//the one he needs.
//Last time he did these calculations he got a headache, so could you help John?
//Task
//Your function wallpaper(l, w, h) should return as a plain English word in lower case the number of rolls he must buy.
//Example:
//wallpaper(4.0, 3.5, 3.0) should return "ten"
//wallpaper(0.0, 3.5, 3.0) should return "zero"
//Notes:
//all rolls(even with incomplete width) are put edge to edge
//0 <= l, w, h(floating numbers); it can happens that w* h * l is zero
//the integer r(number of rolls) will always be less or equal to 20
//FORTH: the number of rolls will be a positive or null integer(not a plain English word; this number can be greater than 20)
//In Javascript English numbers are preloaded and can be accessed as:
//numbers = ["zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve","thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty"]
//For other languages it is not preloaded but you can use the above one if you need it.
    public class Wallpaper
    {
        public static string WallPaper(double l, double w, double h)
        {
            string[] numbers = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty" };
            if (l == 0 || w == 0 || h == 0)
            {
                return numbers[0];
            }
            double perimeter = 2 * (l + w);
            double totalCountLines = perimeter / 0.52;
            double CountLinesOneRoll = 10 / h;
            double rolls = Math.Ceiling((totalCountLines + totalCountLines * 0.15) / CountLinesOneRoll);
            return numbers[(int)rolls];
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
            [TestFixture]
            public static class WallpaperTests
            {

                private static void testing(string actual, string expected)
                {
                    Assert.AreEqual(expected, actual);
                }
            }

                [Test]
            public static void Test1()
            {
                testing(Wallpaper.WallPaper(6.3, 4.5, 3.29), "sixteen");
                testing(Wallpaper.WallPaper(7.8, 2.9, 3.29), "sixteen");
                testing(Wallpaper.WallPaper(6.3, 5.8, 3.13), "seventeen");
                testing(Wallpaper.WallPaper(6.1, 6.7, 2.81), "sixteen");
            }
        }
    }
}
