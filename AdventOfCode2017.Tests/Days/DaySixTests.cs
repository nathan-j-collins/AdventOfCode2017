using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2017.Days;

namespace AdventOfCode2017.Tests.Days
{
    [TestClass]
    public class DaySixTests
    {
        [DataTestMethod]
        [DataRow("2\t8\t8\t5\t4\t2\t3\t1\t5\t5\t1\t2\t15\t13\t5\t14", 3156)]
        [DataRow("2\t4\t1\t2", 5)]
        public void DaySixPartOneReturnsCorrectly(string input, int expected)
        {
            var result = DaySix.PartOne(input);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow("2\t8\t8\t5\t4\t2\t3\t1\t5\t5\t1\t2\t15\t13\t5\t14", 1610)]
        [DataRow("2\t4\t1\t2", 4)]
        public void DaySixPartTwoReturnsCorrectly(string input, int expected)
        {
            var result = DaySix.PartTwo(input);
            Assert.AreEqual(expected, result);
        }
    }
}
