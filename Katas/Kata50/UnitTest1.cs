using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Globalization;

namespace Katas.Kata50
{
    //Finish the solution so that it sorts the passed in array of numbers.If the function passes in an empty array or null/nil value then it should return an empty array.
    //For example:
    //SortNumbers(new int[] { 1, 2, 10, 50, 5 }); // should return new int[] { 1, 2, 5, 10, 50 }
    //SortNumbers(null); // should return new int[] { }
    public class Kata
    {
        public static int[] SortNumbers(int[] nums) => nums == null ? new int[] { } : nums.OrderBy(x => x).ToArray();
        //{
            //Решение 2:
            //if(nums == null)
            //{
            //    return new int[] { };
            //}
            //Array.Sort(nums);
            //return nums;
            //Решение 1:
            //int temp;
            //if (nums == null)
            //{
            //    return new int[] { };
            //}
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = 0; j < nums.Length; j++)
            //    {
            //        if (j != nums.Length - 1 && nums[j] > nums[j + 1])
            //        {
            //            temp = nums[j];
            //            nums[j] = nums[j + 1];
            //            nums[j + 1] = temp;
            //        }
            //    }
            //}
            //return nums;
        //}
    }
    class UnitTest1
    {
        public class Tests
        {
            [SetUp]
            public void Setup()
            {
            }

            [Test]
            public void BasicTests()
            {
                checkNums(new int[] { 1, 2, 3, 10, 5 }, new int[] { 1, 2, 3, 5, 10 });
                checkNums(null, new int[] { });
                checkNums(new int[] { }, new int[] { });
                checkNums(new int[] { 20, 2, 10 }, new int[] { 2, 10, 20 });
                checkNums(new int[] { 2, 20, 10 }, new int[] { 2, 10, 20 });
                checkNums(new int[] { 2, 10, 20 }, new int[] { 2, 10, 20 });
            }

            private void checkNums(int[] nums, int[] expected)
            {
                var actual = Kata.SortNumbers(nums);

                Assert.AreEqual(expected, actual, nums != null ? "{" + string.Join(",", nums) + "}" : "null");
            }
        }
    }
}

