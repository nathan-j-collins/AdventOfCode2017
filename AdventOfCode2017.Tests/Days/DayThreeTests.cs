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
    }
}
