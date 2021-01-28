using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Katas.Kata38
{
//Take an array and remove every second element from the array.Always keep the first element and start removing with the next element.
//Example:
//my_list = ['Keep', 'Remove', 'Keep', 'Remove', 'Keep', ...]
//None of the arrays will be empty, so you don't have to worry about that!
    public static class Kata
    {
        public static object[] RemoveEveryOther(object[] arr) 
        {
            List<object> result = new List<object>();
            for (int i = 0; i < arr.Length; i += 2)
            {
                result.Add(arr[i]);
            }
            return result.ToArray();
            //int length = (int)(Math.Ceiling(arr.Length / 2.0));
            //object[] result = new object[length];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (i == 0)
            //    {
            //        result[i] = arr[i];
            //    }
            //    else if (i % 2 == 0)
            //    {
            //        result[i / 2] = arr[i];
            //    }
            //}
            //return result;
        }
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
            Assert.AreEqual(new object[] { "Hello", "Hello Again" }, Kata.RemoveEveryOther(new object[] { "Hello", "Goodbye", "Hello Again" }));
            Assert.AreEqual(new object[] { new object[] { 1, 2 } }, Kata.RemoveEveryOther(new object[] { new object[] { 1, 2 } }));
            Assert.AreEqual(new object[] { 1, 3, 5, 7, 9 }, Kata.RemoveEveryOther(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
            Assert.AreEqual(new object[] { new object[] { "Goodbye" } }, Kata.RemoveEveryOther(new object[] { new object[] { "Goodbye" }, new Dictionary<string, string>() { { "Great", "Job" } } }));
            Assert.AreEqual(new object[] { }, Kata.RemoveEveryOther(new object[] { }));
        }
    }
}