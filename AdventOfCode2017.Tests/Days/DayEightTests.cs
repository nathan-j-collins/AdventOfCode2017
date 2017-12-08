using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2017.Days;

namespace AdventOfCode2017.Tests.Days
{
    [TestClass]
    public class DayEightTests
    {
        [DataTestMethod]
        [DataRow("b inc 5 if a > 1\r\na inc 1 if b < 5\r\nc dec -10 if a >= 1\r\nc inc -20 if c == 10", 1)]
        public void DayEightPartOneReturnsCorrectly(string input, int expected)
        {
            var result = DayEight.PartOne(input);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow("b inc 5 if a > 1\r\na inc 1 if b < 5\r\nc dec -10 if a >= 1\r\nc inc -20 if c == 10", 10)]
        public void DayEightPartTwoReturnsCorrectly(string input, int expected)
        {
            var result = DayEight.PartTwo(input);
            Assert.AreEqual(expected, result);
        }
    }
}
