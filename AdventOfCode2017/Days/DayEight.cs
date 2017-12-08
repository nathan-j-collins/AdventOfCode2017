using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode2017.Days
{
    public class DayEight
    {
        public static int PartOne(string input)
        {
            return DayEightProcess(input, false);
        }

        public static int PartTwo(string input)
        {
            return DayEightProcess(input, true);
        }

        private static int DayEightProcess(string input, bool partTwo)
        {
            var lines = input.Split("\r\n");
            var dict = new Dictionary<string, int>();
            var highest = 0;
            foreach (var line in lines)
            {
                var split = line.Split(' ');
                var var1 = split[0];
                var var2 = split[4];
                AddToDict(dict, var1);
                AddToDict(dict, var2);

                if (ParseIfStatement(dict, split))
                {
                    AddSubtract(dict, split);
                }
                var tempHigh = GetHighestValue(dict);
                if (tempHigh > highest)
                {
                    highest = tempHigh;
                }
            }
            return partTwo ? highest : GetHighestValue(dict);
        }

        private static int GetHighestValue(Dictionary<string, int> dict)
        {
            var highest = dict.First().Value;
            foreach (var entry in dict)
            {
                if (entry.Value > highest)
                {
                    highest = entry.Value;
                }
            }

            return highest;
        }

        private static void AddSubtract(Dictionary<string, int> dict, string[] split)
        {
            switch (split[1])
            {
                case "inc":
                    dict[split[0]] += int.Parse(split[2]);
                    break;
                case "dec":
                    dict[split[0]] -= int.Parse(split[2]);
                    break;
            }
        }

        private static bool ParseIfStatement(Dictionary<string, int> dict, string[] split)
        {
            switch (split[5])
            {
                case ">":
                    return dict[split[4]] > int.Parse(split[6]);
                case "<":
                    return dict[split[4]] < int.Parse(split[6]);
                case "<=":
                    return dict[split[4]] <= int.Parse(split[6]);
                case ">=":
                    return dict[split[4]] >= int.Parse(split[6]);
                case "==":
                    return dict[split[4]] == int.Parse(split[6]);
                case "!=":
                    return dict[split[4]] != int.Parse(split[6]);
            }
            return false;
        }

        private static void AddToDict(Dictionary<string, int> dict, string key)
        {
            if (!dict.ContainsKey(key))
            {
                dict[key] = 0;
            }
        }
    }
}
