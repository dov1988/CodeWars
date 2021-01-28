using NUnit.Framework;

namespace Kata26
{
//Your classmates asked you to copy some paperwork for them.You know that there are 'n' classmates and the paperwork has 'm' pages.
//Your task is to calculate how many blank pages do you need.
//Example:
//Paperwork(5, 5) == 25
//Note: if n< 0 or m< 0 return 0!
//Waiting for translations and Feedback! Thanks!


    public static class Paper
    {
        public static int Paperwork(int n, int m) => (n > 0 && m > 0) ? m * n : 0;
//        {
//            if(n<0 || m< 0)
//            {
//                return 0;
//            }
//            else
//            {
//                return m* n;
//            }
//       }
    }
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test()
        {
            Assert.AreEqual(25, Paper.Paperwork(5, 5));
        }
    }
}
