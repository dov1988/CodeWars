using NUnit.Framework;

namespace Kata36
{
    //You were camping with your friends far away from home, but when it's time to go back, you realize that your 
    //fuel is running out and the nearest pump is 50 miles away! You know that on average, your car runs on about 
    //25 miles per gallon. There are 2 gallons left. Considering these factors, write a function that tells you if 
    //it is possible to get to the pump or not. Function should return true (1 in Prolog) if it is possible and false 
    //(0 in Prolog) if not. The input values are always positive.

    public static class Kata
    {
        public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft) => mpg * fuelLeft >= distanceToPump;
        //{
        //    throw new NotImplementedException();
        //}
    }
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(true, Kata.ZeroFuel(50, 25, 2));
            Assert.AreEqual(false, Kata.ZeroFuel(100, 50, 1));
        }
    }
}