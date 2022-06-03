using NUnit.Framework;
using System;

namespace Summator
{
    public class Tests
    {
        [Test]
        public void Test_Two_Positive_Numbers()
        {
            int result = Summator.Sum(new int[] { 4, 5 });
            Assert.That(result == 9);
        }
        [Test]
        public void Test_Two_Negative_Numbers()
        {
            int result = Summator.Sum(new int[] { -6, -5 });
            Assert.That(result == -11);
        }
        [Test]
        public void Test_0()
        {
            int result = Summator.Sum(new int[] {0});
            Assert.That(result == 0);
        }
        [Test]
        public void TestPosNegNum()
        {
            int result = Summator.Sum(new int[] { -4, 5 });
            Assert.That(result == 1);
        }
        [Test]
        public void Test_multiple_nums()

        {
            int result = Summator.Sum(new int[] { 4, 5, 8, 10, 15 });
            int actual = 42;
            Assert.AreEqual(result, actual);

        }
        [Test]
        public void Test_One_num()

        {
            int result = Summator.Sum(new int[] { 4 });
            int actual = 4;
            Assert.AreEqual(result, actual);

        }
    }  
}