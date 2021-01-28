using NUnit.Framework;

namespace Kata22
{
    //Given three integers a, b, c, return the largest number obtained after inserting the following operators and brackets: +, *, ()
    //In other words, try every combination of a, b, c with[*+()] , and return the Maximum Obtained
    //Consider an Example :
    //With the numbers are 1, 2 and 3 , here are some ways of placing signs and brackets:
    //1 * (2 + 3) = 5
    //1 * 2 * 3 = 6
    //1 + 2 * 3 = 7
    //(1 + 2) * 3 = 9
    //So the maximum value that you can obtain is 9.
    //Notes
    //The numbers are always positive.
    //The numbers are in the range (1  ≤  a, b, c ≤  10).
    //You can use the same operation more than once.
    //It's not necessary to place all the signs and brackets.
    //Repetition in numbers may occur.
    //You cannot swap the operands.For instance, in the given example you cannot get expression(1 + 3) * 2 = 8.
    //Input >> Output Examples:
    //expressionsMatter(1,2,3)  ==>  return 9
    //Explanation:
    //After placing signs and brackets, the Maximum value obtained from the expression(1+2) * 3 = 9.
    //expressionsMatter(1,1,1)  ==>  return 3
    //Explanation:
    //After placing signs, the Maximum value obtained from the expression is 1 + 1 + 1 = 3.
    //expressionsMatter(9,1,1)  ==>  return 18
    //Explanation:
    //After placing signs and brackets, the Maximum value obtained from the expression is 9 * (1+1) = 18.
    public class Kata
    {
        public static int ExpressionsMatter(int a, int b, int c)
        {
            if (a == b && b == c)
            {
                if (a == 1)
                {
                    return a + b + c;
                }
                else
                {
                    return a * b * c;
                }
            }
            else if (a == 1)
            {
                if (a == c)
                {
                    return a + b + c;
                }
                return (a + b) * c;
            }
            else if (b == 1)
            {
                if (a >= c || c == 1)
                {
                    return a * (b + c);
                }
                else
                {
                    return (a + b) * c;
                }
            }
            else if (c == 1 || c == b && c == 1)
            {
                return a * (b + c);
            }
            else
            {
                return a * b * c;
            }
            //if (a == b && b == c)
            //{

            //        return a * b * c;
            //}
            //int one = a * b * c;
            //int two = a * (b + c);
            //int tree = (a + b) * c;
            //int four = a + b * c;
            //int five = a * b + c;
            //int six = a + b + c;
            //if (one >= two && one >= tree && one >= four && one >= five && one >= six)
            //{
            //    return one;
            //}
            //else if (two >= one && two >= tree && two >= four && two >= five && two >= six)
            //{
            //    return two;
            //}
            //else if (tree >= one && tree >= two && tree >= four && tree >= five && tree >= six)
            //{
            //    return tree;
            //}
            //else if (four >= two && four >= tree && four >= one && four >= five && four >= six)
            //{
            //    return four;
            //}
            //else if (five >= two && five >= tree && five >= one && five >= four && five >= six)
            //{
            //    return five;
            //}
            //else
            //{
            //    return six;
            //}
        }
    }
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestFixture]
        public class ExpressionsMatter
        {
            [TestCase(6, 2, 1, 2)]
            [TestCase(3, 1, 1, 1)]
            [TestCase(4, 2, 1, 1)]
            [TestCase(9, 1, 2, 3)]
            [TestCase(5, 1, 3, 1)]
            [TestCase(8, 2, 2, 2)]
            public void CheckSmallValues(int expected, params int[] a)
            {
                Assert.That(Kata.ExpressionsMatter(a[0], a[1], a[2]), Is.EqualTo(expected));
            }
            [TestCase(020, 5, 1, 3)]
            [TestCase(105, 3, 5, 7)]
            [TestCase(035, 5, 6, 1)]
            [TestCase(008, 1, 6, 1)]
            [TestCase(014, 2, 6, 1)]
            [TestCase(048, 6, 7, 1)]
            public void CheckIntermediateValues(int expected, params int[] a)
            {
                Assert.That(Kata.ExpressionsMatter(a[0], a[1], a[2]), Is.EqualTo(expected));
            }
            [TestCase(060, 02, 10, 03)]
            [TestCase(027, 01, 08, 03)]
            [TestCase(126, 09, 07, 02)]
            [TestCase(020, 01, 01, 10)]
            [TestCase(018, 09, 01, 01)]
            [TestCase(300, 10, 05, 06)]
            [TestCase(012, 01, 10, 01)]
            public void CheckMixedValues(int expected, params int[] a)
            {
                Assert.That(Kata.ExpressionsMatter(a[0], a[1], a[2]), Is.EqualTo(expected));
            }
        }
    }
}