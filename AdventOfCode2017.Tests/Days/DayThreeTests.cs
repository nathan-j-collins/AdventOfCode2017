using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2017.Days;

namespace AdventOfCode2017.Tests.Days
{
    [TestClass]
    public class DayThreeTests
    {
        [DataTestMethod]
        [DataRow(64, 7)]
        [DataRow(38, 5)]
        public void DayThreePartOneReturnsCorrectly(int input, int expected)
        {
            var result = DayThree.PartOne(input);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(125, 133)]
        [DataRow(10, 11)]
        public void DayThreePartTwoReturnsCorrectly(int input, int expected)
        {
            DayThree.Reset();
            var result = DayThree.PartTwo(input);
            Assert.AreEqual(expected, result);
        }
    }
}
