using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2017.Days;
using System.Collections.Generic;

namespace AdventOfCode2017.Tests.Days
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow("112233", 6)]
        [DataRow("112231", 4)]
        [DataRow("9879911229", 21)]
        public void PartOneReturnsCorrectly(string input, int expected)
        {
            var result = DayOne.PartOne(input);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow("1212", 6)]
        [DataRow("112233", 0)]
        [DataRow("123456123456", 42)]
        public void PartTwoReturnsCorrectly(string input, int expected)
        {
            var result = DayOne.PartTwo(input);
            Assert.AreEqual(expected, result);
        }
    }
}
