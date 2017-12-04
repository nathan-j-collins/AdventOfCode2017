using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2017.Days
{
    public class DayTwo
    {
        public static int PartOne(string input)
        {
            int result = 0;

            var lines = input.Split('\n');

            foreach(var line in lines)
            {
                var numbers = line.Split('\t');
                int.TryParse(numbers[0], out int highestInt);
                int lowestInt = highestInt;
                for (int i = 1; i < numbers.Length; i++)
                {
                    int.TryParse(numbers[i], out int currentInt);

                    if (currentInt > highestInt)
                    {
                        highestInt = currentInt;
                    }
                    if (currentInt < lowestInt)
                    {
                        lowestInt = currentInt;
                    }

                }

                result += (highestInt - lowestInt);
            }

            return result;
        }

        public static int PartTwo(string input)
        {
            int result = 0;

            var lines = input.Split('\n');

            foreach (var line in lines)
            {
                var numbers = line.Split('\t');
                for (int i = 1; i < numbers.Length; i++)
                {
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        if (i == j)
                        {
                            continue;
                        }

                        int.TryParse(numbers[i], out int firstInt);
                        int.TryParse(numbers[j], out int secondInt);

                        if (firstInt % secondInt == 0)
                        {
                            result += (firstInt / secondInt);
                        }
                    }
                }
            }

            return result;
        }
    }
}
