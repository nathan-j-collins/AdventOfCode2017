using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2017.Days;

namespace AdventOfCode2017.Tests.Days
{
    [TestClass]
    public class DayFiveTests
    {
        [DataTestMethod]
        [DataRow("0\n3\n0\n1\n-3", 5)]
        public void DayFivePartOneReturnsCorrectly(string input, int expected)
        {
            var result = DayFive.PartOne(input);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow("0\n3\n0\n1\n-3", 10)]
        public void DayFivePartTwoReturnsCorrectly(string input, int expected)
        {
            var result = DayFive.PartTwo(input);
            Assert.AreEqual(expected, result);
        }
    }
}
