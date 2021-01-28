using NUnit.Framework;
using System.Resources;

namespace Kata16
{
//    Description:
//Make a simple function called greet that returns the most-famous "hello world!".
//    Style Points:
//Sure, this is about as easy as it gets. But how clever can you be to create the most creative hello world you can think of? What is a "hello world" solution you would want to show your friends?
    public static class Kata
    {
        public static string Greet()
        {
            return "hello world!";
        }
    }
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldReturnHelloWorld()
        {
            Assert.AreEqual("hello world!", Kata.Greet());
        }
    }
}