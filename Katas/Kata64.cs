using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Katas.Kata64
{
    //Some new cashiers started to work at your restaurant.
    //They are good at taking orders, but they don't know how to capitalize words, or use a space bar!
    //All the orders they create look something like this:
    //"milkshakepizzachickenfriescokeburgerpizzasandwichmilkshakepizza"
    //The kitchen staff are threatening to quit, because of how difficult it is to read the orders.
    //Their preference is to get the orders as a nice clean string with spaces and capitals like so:
    //"Burger Fries Chicken Pizza Pizza Pizza Sandwich Milkshake Milkshake Coke"
    //The kitchen staff expect the items to be in the same order as they appear in the menu.
    //The menu items are fairly simple, there is no overlap in the names of the items:
    //1. Burger
    //2. Fries
    //3. Chicken
    //4. Pizza
    //5. Sandwich
    //6. Onionrings
    //7. Milkshake
    //8. Coke

    public static class Kata
    {
        public static string GetOrder(string input)
        {
            Dictionary<string, int> menu = new Dictionary<string, int>()
            {
                { "Burger", 0 },
                { "Fries", 0 },
                { "Chicken", 0},
                { "Pizza", 0 },
                { "Sandwich", 0 },
                { "Onionrings", 0 },
                { "Milkshake", 0 },
                { "Coke", 0 }
            };
            string order = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (order == "")
                {
                    order += char.ToUpper(input[i]);
                }
                else
                {
                    order += input[i];
                }
                if (menu.ContainsKey(order))
                {
                    menu[order]++;
                    order = "";
                }
            }
            foreach (string key in menu.Keys)
            {
                for (int i = 0; i < menu[key]; i++)
                {
                    if (order == "")
                    {
                        order += key;
                    }
                    else
                    {
                        order += " " + key;
                    }
                }
            }
            return order;
        }
    }

    class UnitTest1
    {
        class KataTestClass
        {
            [Test]
            public void Test1()
            {
                Assert.AreEqual("Burger Fries Chicken Pizza Pizza Pizza Sandwich Milkshake Milkshake Coke",
                Kata.GetOrder("milkshakepizzachickenfriescokeburgerpizzasandwichmilkshakepizza"));
            }

            [Test]
            public void Test2()
            {
                Assert.AreEqual("Burger Fries Fries Chicken Pizza Sandwich Milkshake Coke",
                Kata.GetOrder("pizzachickenfriesburgercokemilkshakefriessandwich"));
            }

        }
    }
}

