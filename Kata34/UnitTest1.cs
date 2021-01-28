using NUnit.Framework;

namespace Kata34
{
    //Your task is to create functionisDivideBy(or is_divide_by) to check if an integer number is divisible by each out of two arguments.
    //A few cases:
    //(-12, 2, -6)  ->  true
    //(-12, 2, -5)  ->  false
    //(45, 1, 6)    ->  false
    //(45, 5, 15)   ->  true
    //(4, 1, 4)     ->  true
    //(15, -5, 3)   ->  true

    public class Kata
    {
        public static bool isDivideBy(int number, int a, int b) => number % a == 0 && number % b == 0;
    }
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(true, Kata.isDivideBy(-12, 2, 6));
            Assert.AreEqual(false, Kata.isDivideBy(-12, 2, -5));
            Assert.AreEqual(false, Kata.isDivideBy(-45, 1, 6));
            Assert.AreEqual(true, Kata.isDivideBy(45, 5, 15));
            Assert.AreEqual(true, Kata.isDivideBy(4, 1, 4));
            Assert.AreEqual(true, Kata.isDivideBy(15, -5, 3));
        }
    }
}