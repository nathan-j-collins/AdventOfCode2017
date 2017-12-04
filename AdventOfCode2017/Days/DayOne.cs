using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2017.Days
{
    public class DayOne
    {
        public static int PartOne(string input)
        {
            int result = 0;
            int.TryParse(input.Substring(0, 1), out int firstInt);
            int previousInt = firstInt;

            for (int i = 1; i < input.Length; i++)
            {
                int.TryParse(input.Substring(i, 1), out int currentInt);

                if (currentInt == previousInt)
                {
                    result += currentInt;
                }
                previousInt = currentInt;
            }

            if (previousInt == firstInt)
            {
                result += previousInt;
            }

            return result;
        }

        public static int PartTwo(string input)
        {
            int result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int.TryParse(input.Substring(i, 1), out int currentInt);

                int nextIndex = i + (input.Length / 2);
                if (nextIndex >= input.Length)
                {
                    nextIndex = i - (input.Length / 2);
                }

                int.TryParse(input.Substring(nextIndex, 1), out int nextInt);

                if (currentInt == nextInt)
                {
                    result += currentInt;
                }
            }

            return result;
        }
    }
}
