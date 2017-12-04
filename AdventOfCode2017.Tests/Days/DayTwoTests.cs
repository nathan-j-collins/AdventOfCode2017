using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2017.Days;

namespace AdventOfCode2017.Tests.Days
{
    [TestClass]
    public class DayTwoTests
    {
        [DataTestMethod]
        [DataRow("1\t2\t3\t4\n5\t6\t7\t8", 6)]
        [DataRow("1\t200\t356\t412\n512\t6321\t7654\t8867", 8766)]
        public void DayTwoPartOneReturnsCorrectly(string input, int expected)
        {
            var result = DayTwo.PartOne(input);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow("1\t2\t3\t4\n5\t6\t7\t8", 11)]
        public void DayTwoPartTwoReturnsCorrectly(string input, int expected)
        {
            var result = DayTwo.PartTwo(input);
            Assert.AreEqual(expected, result);
        }
    }
}
