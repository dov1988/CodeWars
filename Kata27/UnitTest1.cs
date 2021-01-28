using NUnit.Framework;
using System.Linq;

namespace Kata27
{
//You will be given an array a and a value x.All you need to do is check whether the provided array contains the value.
//Array can contain numbers or strings.X can be either.
//Return true if the array contains the value, false if not.
    public class Kata
    {
        public static bool Check(object[] a, object x) => a.Contains(x);
        //{
        //    foreach (object item in a)
        //    {
        //        if(item.Equals(x))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
    }
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(true, Kata.Check(new object[] { 66, 101 }, 66));
            Assert.AreEqual(true, Kata.Check(new object[] { 80, 117, 115, 104, 45, 85, 112, 115 }, 45));

            Assert.AreEqual(true, Kata.Check(new object[] { 't', 'e', 's', 't' }, 'e'));
            Assert.AreEqual(false, Kata.Check(new object[] { "what", "a", "great", "kata" }, "kat"));
        }
    }
}