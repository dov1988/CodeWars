using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Katas.Kata65
{
    //Write a function, which takes a non-negative integer(seconds) as input and returns the time in a human-readable format(HH:MM:SS)
    //HH = hours, padded to 2 digits, range: 00 - 99
    //MM = minutes, padded to 2 digits, range: 00 - 59
    //SS = seconds, padded to 2 digits, range: 00 - 59
    //The maximum time never exceeds 359999 (99:59:59)
    //You can find some examples in the test fixtures.

    public static class TimeFormat
    {
        public static string GetReadableTime(int seconds)
        {
            int hours = seconds / 3600;
            int minutes = (seconds - hours * 3600) / 60;
            int secondsResult = seconds % 60;
            return String.Format("{0:d2}:{1:d2}:{2:d2}", hours, minutes, secondsResult);
        }
    }

    class UnitTest1
    {
            [Test]
            public void HumanReadableTest()
            {
                Assert.AreEqual("00:00:00", TimeFormat.GetReadableTime(0));
                Assert.AreEqual("00:00:05", TimeFormat.GetReadableTime(5));
                Assert.AreEqual("00:01:00", TimeFormat.GetReadableTime(60));
                Assert.AreEqual("23:59:59", TimeFormat.GetReadableTime(86399));
                Assert.AreEqual("99:59:59", TimeFormat.GetReadableTime(359999));
            }

    }
}

