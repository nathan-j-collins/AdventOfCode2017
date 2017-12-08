using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2017.Days;

namespace AdventOfCode2017.Tests.Days
{
    [TestClass]
    public class DaySevenTests
    {
        [DataTestMethod]
        [DataRow("pbga (66)\r\nxhth (57)\r\nebii (61)\r\nhavc (66)\r\nktlj (57)\r\nfwft (72) -> ktlj, cntj, xhth\r\nqoyq (66)\r\npadx (45) -> pbga, havc, qoyq\r\ntknk (41) -> ugml, padx, fwft\r\njptl (61)\r\nugml (68) -> gyxo, ebii, jptl\r\ngyxo (61)\r\ncntj (57)", "tknk")]
        public void DaySevenPartOneReturnsCorrectly(string input, string expected)
        {
            var result = DaySeven.PartOne(input);
            Assert.AreEqual(expected, result);
        }

        //[DataTestMethod]
        //[DataRow("pbga (66)\r\nxhth (57)\r\nebii (61)\r\nhavc (66)\r\nktlj (57)\r\nfwft (72) -> ktlj, cntj, xhth\r\nqoyq (66)\r\npadx (45) -> pbga, havc, qoyq\r\ntknk (41) -> ugml, padx, fwft\r\njptl (61)\r\nugml (68) -> gyxo, ebii, jptl\r\ngyxo (61)\r\ncntj (57)", 60)]
        //public void DaySevenPartTwoReturnsCorrectly(string input, int expected)
        //{
        //    var result = DaySeven.PartTwo(input);
        //    Assert.AreEqual(expected, result);
        //}
    }
}
