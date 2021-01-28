using NUnit.Framework;
using System.Linq;

namespace Kata3
{

    public class Kata
    {
        public static bool FindNumber(int number, int[] ids)
        {
            for (int i = 0; i < ids.Length; i++)
            {
                if (ids[i] == number)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public static int NextId(int[] ids)
        {
            int minId = 0;
            if (FindNumber(minId, ids))
            {
                for (int i = 0; i < ids.Length; i++)
                {
                    if (minId + 1 == ids[i])
                    {
                        minId = ids[i];
                        continue;
                    }
                    else if (i == ids.Length - 1)
                    {
                        return minId + 1;
                    }
                    else
                    {
                        continue;
                    }
                }
                return minId + 1;
            }
            else
            {
                return minId;
            }
        }
    }
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}