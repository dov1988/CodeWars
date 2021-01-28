using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NUnit.Framework;

namespace Katas.Kata44
{
    //    Your friend invites you out to a cool floating pontoon around 1km off the beach.Among other things, the pontoon has a huge slide that drops you out right into the ocean, a small way from a set of stairs used to climb out.

    //As you plunge out of the slide into the water, you see a shark hovering in the darkness under the pontoon... Crap!

    //You need to work out if the shark will get to you before you can get to the pontoon.To make it easier... as you do the mental calculations in the water you either freeze when you realise you are dead, or swim when you realise you can make it!

    //You are given 5 variables: sharkDistance = distance the shark needs to cover to eat you in metres, sharkSpeed = how fast it can move in metres/second, pontoonDistance = how far you need to swim to safety in metres, youSpeed = how fast you can swim in metres/second, dolphin = a boolean, if true, you can half the swimming speed of the shark as the dolphin will attack it.

    //If you make it, return "Alive!", if not, return "Shark Bait!".


    public class Kata
    {
        public static string Shark(
          int pontoonDistance,
          int sharkDistance,
          int yourSpeed,
          int sharkSpeed,
          bool dolphin) //=> sharkDistance / (double)sharkSpeed > pontoonDistance / (dolphin ? 2 * yourSpeed : yourSpeed) ? "Alive!" : "Shark Bait!";
        {
            if(pontoonDistance / (double) yourSpeed < sharkDistance /(double) sharkSpeed)
            {
                return "Alive!";
            }
            else if(pontoonDistance / yourSpeed/2.0 < sharkDistance / (double) sharkSpeed && dolphin == true)
            {
                return "Alive!";
            }
            else
            {
                return "Shark Bait!";
            }
        }
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
        public void BasicTest()
        {
            Assert.AreEqual("Alive!", Kata.Shark(12, 50, 4, 8, true));
            Assert.AreEqual("Alive!", Kata.Shark(12, 50, 4, 8, false));
            Assert.AreEqual("Alive!", Kata.Shark(7, 55, 4, 16, true));
            Assert.AreEqual("Shark Bait!", Kata.Shark(24, 0, 4, 8, true));
            Assert.AreEqual("Shark Bait!", Kata.Shark(40, 35, 3, 20, true));
            Assert.AreEqual("Alive!", Kata.Shark(7, 8, 3, 4, true));
            Assert.AreEqual("Shark Bait!", Kata.Shark(7, 8, 3, 4, false));
        }
    }
}
}
