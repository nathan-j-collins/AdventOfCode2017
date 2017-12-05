using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2017.Days;

namespace AdventOfCode2017.Tests.Days
{
    [TestClass]
    public class DayFourTests
    {
        [DataTestMethod]
        [DataRow("a b c d\r\nb b a b", 1)]
        [DataRow("aasdasda qweqweqeq gdfgdfgd asdasdaasdasd\r\n12312312321 iyuiuyiyu 809809 spadkpasodkasp", 2)]
        public void DayFourPartOneReturnsCorrectly(string input, int expected)
        {
            var result = DayFour.PartOne(input);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow("a b c d\r\nb b ab ba", 1)]
        [DataRow("aasdasda qweqweqeq gdfgdfgd asdasdaasdasd\r\n12312312321 iyuiuyiyu 809809 spadkpasodkasp", 2)]
        public void DayFourPartTwoReturnsCorrectly(string input, int expected)
        {
            var result = DayFour.PartTwo(input);
            Assert.AreEqual(expected, result);
        }
    }
}
