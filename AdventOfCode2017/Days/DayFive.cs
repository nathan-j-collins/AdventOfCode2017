using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AdventOfCode2017.Days
{
    public class DayFive
    {
        public static int PartOne(string input)
        {
            var numbers = input.Split('\n').ToList().ConvertAll(int.Parse);
            var index = 0;
            var counter = 0;
            while (true)
            {
                if(numbers.Count <= index)
                {
                    return counter;
                }

                var tempIndex = numbers[index];
                numbers[index]++;
                index += tempIndex;
                counter++;
            }
        }

        public static int PartTwo(string input)
        {
            var numbers = input.Split('\n').ToList().ConvertAll(int.Parse);
            var index = 0;
            var counter = 0;
            while (true)
            {
                if (numbers.Count <= index)
                {
                    return counter;
                }

                var tempIndex = numbers[index];
                if (tempIndex >= 3)
                {
                    numbers[index]--;
                }
                else
                {
                    numbers[index]++;
                }
                index += tempIndex;
                counter++;
            }
        }
    }
}
