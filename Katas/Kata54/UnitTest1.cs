using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Katas.Kata54
{
    //You receive the name of a city as a string, and you need to return a string that shows how many times each letter shows up in the string by using an asterisk(*).
    //For example:
    //"Chicago"  -->  "c:**,h:*,i:*,a:*,g:*,o:*"
    //As you can see, the letter c is shown only once, but wih 2 asterisks.
    //The return string should include only the letters(not the dashes, spaces, apostrophes, etc). There should be no spaces in the output, and the different letters are separated by a comma(,) as seen in the example above.
    //Note that the return string must list the letters in order of their first appearence in the original string.
    //More examples:
    //"Bangkok"    -->  "b:*,a:*,n:*,g:*,k:**,o:*"
    //"Las Vegas"  -->  "l:*,a:**,s:**,v:*,e:*,g:*"
    //Have fun! ;)


    public class Kata
    {
        public static string GetStrings(string city)
        {
            return string.Join(
                ',',
                city
                    .ToLower()
                    .Where(char.IsLetter)
                    .GroupBy(huy => huy)
                    .Select(pizda => $"{pizda.Key}:{new String('*', pizda.Count())}")
            );
            //string result = "";
            //int countLetter = city.Count(x => char.IsLetter(x));
            //city = city.ToLower();
            //for (int i = 0; i < city.Length; i++)
            //{
            //    if (char.IsLetter(city[i]))
            //    {
            //        if (!result.Contains(city[i]))
            //        {
            //            int count = city.Count(x => x == city[i]);
            //            result += city[i] + ":" + new string('*', count);
            //            if (result.Count(x => x == '*') != countLetter)
            //            {
            //                result += ",";
            //            }
            //        }
            //    }
            //}
            //return result;
        }
    }
    class Kata55
    {
        public class Tests
        {
            [SetUp]
            public void Setup()
            {
            }

            [Test]
            public void GenericTests()
            {
                Assert.AreEqual("c:**,h:*,i:*,a:*,g:*,o:*", Kata.GetStrings("Chicago"));
                Assert.AreEqual("b:*,a:*,n:*,g:*,k:**,o:*", Kata.GetStrings("Bangkok"));
                Assert.AreEqual("l:*,a:**,s:**,v:*,e:*,g:*", Kata.GetStrings("Las Vegas"));
            }
        }
    }
}

