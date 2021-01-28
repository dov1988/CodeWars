using NUnit.Framework;
using System;

namespace Kata4
{
    // ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits.

    //If the function is passed a valid PIN string, return true, else return false.
    public class Kata
    {
        public static bool ValidatePin(string pin)
        {
            char[] array = pin.ToCharArray();
            if (array.Length == 4 || array.Length == 6)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (Char.IsNumber(array[i]))
                    {
                        continue;
                    }
                    else { return false; }
                }
                return true;
            }
            else { return false; }
        }
    }
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}