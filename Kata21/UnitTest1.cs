using NUnit.Framework;

namespace Kata21
{
//This function takes two numbers as parameters, the first number being the coefficient, and the second number being the exponent.
//Your function should multiply the two numbers, and then subtract 1 from the exponent.Then, it has to print out an expression (like 28x^7). "^1" should not be truncated when exponent = 2.
//For example:
//derive(7, 8)
//In this case, the function should multiply 7 and 8, and then subtract 1 from 8. It should output "56x^7", the first number 56 being the product of the two numbers, and the second number being the exponent minus 1.
//derive(7, 8) --> this should output "56x^7" 
//derive(5, 9) --> this should output "45x^8" 
//Notes:
//The output of this function should be a string
//The exponent will never be 1, and neither number will ever be 0
    public class Kata
    {
        public static string Derive(double coefficient, double exponent)
        {
            double composition = coefficient * exponent;
            double newExponent = exponent - 1;
            return composition + "x^" + newExponent; 
        }
    }
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestFixture]
        public class SolutionTest
        {

            private static object[] Basic_Test_Cases = new object[]
            {
      new object[] {7, 8, "56x^7"},
      new object[] {5, 9, "45x^8"},
            };

            [Test, TestCaseSource(typeof(SolutionTest), "Basic_Test_Cases")]
            public void Basic_Test(double coefficient, double exponent, string expected)
            {
                Assert.AreEqual(expected, Kata.Derive(coefficient, exponent));
            }
        }
    }
}