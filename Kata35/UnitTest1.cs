using NUnit.Framework;

namespace Kata35
{
    //In this Kata we are passing a number (n) into a function.
    //Your code will determine if the number passed is even (or not).
    //The function needs to return either a true or false.
    //Numbers may be positive or negative, integers or floats.
    //Floats are considered UNeven for this kata.
    public class Number
    {
        public bool IsEven(double n) => n % 2 == 0;
        //{
        //    // Your awesome code here!
        //}
    }
    public class Tests
    {
        private Number num;
        [SetUp]
        public void SetUp()
        {
            num = new Number();
        }

        [TearDown]
        public void TearDown()
        {
            num = null;
        }

        [Test]
        public void Tests1()
        {
            Assert.AreEqual(true, num.IsEven(0));
            Assert.AreEqual(false, num.IsEven(0.5));
            Assert.AreEqual(false, num.IsEven(1));
            Assert.AreEqual(true, num.IsEven(2));
            Assert.AreEqual(true, num.IsEven(-4));
        }
    }
}