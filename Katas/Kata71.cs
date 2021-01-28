using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Katas.Kata71
{
    //Sheldon, Leonard, Penny, Rajesh and Howard are in the queue for a "Double Cola" drink vending machine; there are no other people in the queue.The first one in the queue (Sheldon) buys a can, drinks it and doubles! The resulting two Sheldons go to the end of the queue.Then the next in the queue (Leonard) buys a can, drinks it and gets to the end of the queue as two Leonards, and so on.
    //For example, Penny drinks the third can of cola and the queue will look like this:
    //Rajesh, Howard, Sheldon, Sheldon, Leonard, Leonard, Penny, Penny
    //Write a program that will return the name of the person who will drink the n-th cola.
    //Input:
    //The input data consist of an array which contains at least 1 name, and single integer n which may go as high as the biggest number your language of choice supports (if there's such limit, of course).
    //Output / Examples:
    //Return the single line — the name of the person who drinks the n-th can of cola. The cans are numbered starting from 1.
    //string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
    //Line.WhoIsNext(names, 1) == "Sheldon"
    //Line.WhoIsNext(names, 52) == "Penny"
    //Line.WhoIsNext(names, 7230702951) == "Leonard"
    public class Line
    {
        public static string WhoIsNext(string[] names, long n)
        {
            int doubleName = 2;
            long queue = names.Length;
            int index = 0;
            if (n <= 5)
            {
                return names[n - 1];
            }
            for (int i = 0; queue < n; i++)
            {
                queue += doubleName;
                if (i < names.Length)
                {
                    index = i;
                }
                if (i == names.Length - 1)
                {
                    doubleName *= 2;
                    i = -1;
                }
            }
            return names[index];
        }
    }

    [TestFixture]
    public class ListTests
    {
        [Test]
        public void Test1()
        {
            string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
            int n = 1;
            Assert.AreEqual("Sheldon", Line.WhoIsNext(names, n));
        }

        [Test]
        public void Test2()
        {
            string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
            int n = 6;
            Assert.AreEqual("Sheldon", Line.WhoIsNext(names, n));
        }
    }
}

