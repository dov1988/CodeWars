using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Katas.Kata68
{
//ROT13 is a simple letter substitution cipher that replaces a letter with the letter 13 letters after it in the alphabet.ROT13 is an example of the Caesar cipher.
//Create a function that takes a string and returns the string ciphered with Rot13. If there are numbers or special characters included in the string, they should 
//be returned as they are. Only letters from the latin/english alphabet should be shifted, like in the original Rot13 "implementation".

    public class Kata
    {
        public static string Rot13(string message)
        {
            StringBuilder result = new StringBuilder();
            int offset = 13;
            for (int i = 0; i < message.Length; i++)
            {
                if (char.IsLetter(message[i]))
                {
                    if (char.ToLower(message[i]) + offset > 'z')
                    {
                        result.Append(Convert.ToChar('a' - 1 + message[i] + offset - 'z'));
                    }
                    else
                    {
                        result.Append(Convert.ToChar(message[i] + offset));
                    }
                }
                else
                {
                    result.Append(message[i]);
                }
            }
            return result.ToString();
        }

    }

    class UnitTest1
    {
        [Test, Description("test")]
        public void testTest()
        {
            Assert.AreEqual("grfg", Kata.Rot13("test"), String.Format("Input: test, Expected Output: grfg, Actual Output: {0}", Kata.Rot13("test")));
        }

        [Test, Description("Test")]
        public void TestTest()
        {
            Assert.AreEqual("Grfg", Kata.Rot13("Test"), String.Format("Input: Test, Expected Output: Grfg, Actual Output: {0}", Kata.Rot13("Test")));
        }
    }
}

