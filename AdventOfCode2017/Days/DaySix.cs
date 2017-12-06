using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2017.Days
{
    public class DaySix
    {
        public static int PartOne(string input)
        {
            return ProcessDaySix(input, false);
        }

        public static int PartTwo(string input)
        {
            return ProcessDaySix(input, true);
        }

        private static int ProcessDaySix(string input, bool partTwo)
        {
            var counter = 0;
            input = "2\t8\t8\t5\t4\t2\t3\t1\t5\t5\t1\t2\t15\t13\t5\t14";
            var dict = new Dictionary<string, bool>();

            var numbers = input.Split('\t').ToList().ConvertAll(int.Parse);
            var startPartTwo = false;
            var first = string.Empty;

            while (true)
            {
                var indexOfHighest = GetHighestIndex(numbers);
                var highestNumber = numbers[indexOfHighest];

                numbers[indexOfHighest] = 0;

                var remainder = numbers.Count % highestNumber;
                var amount = (int)Math.Round((double)highestNumber / numbers.Count, 0, MidpointRounding.AwayFromZero);

                Redistribute(numbers, indexOfHighest, highestNumber, remainder, amount);

                counter++;

                var numbersAsString = string.Join(",", numbers);
                if (startPartTwo && numbersAsString.Equals(first))
                {
                    return counter;
                }

                if (dict.ContainsKey(numbersAsString) && !startPartTwo)
                {
                    if (partTwo)
                    {
                        startPartTwo = true;
                        first = numbersAsString;
                        counter = 0;
                    }
                    else
                    {
                        return counter;
                    }
                }
                else
                {
                    dict[numbersAsString] = true;
                }
            }
        }

        private static void Redistribute(List<int> numbers, int indexOfHighest, int highestNumber, int remainder, int amount)
        {
            if (highestNumber < numbers.Count)
            {
                var indexToChange = indexOfHighest + 1;
                for (int i = 0; i < highestNumber; i++)
                {
                    if (indexToChange == numbers.Count)
                    {
                        indexToChange = 0;
                    }

                    numbers[indexToChange] += 1;
                    indexToChange++;
                }
            }
            else
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (i == indexOfHighest)
                    {
                        numbers[i] += remainder;
                    }
                    else
                    {
                        numbers[i] += amount;
                    }
                }
            }
        }

        private static int GetHighestIndex(List<int> list)
        {
            var highest = 0;
            var index = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > highest)
                {
                    highest = list[i];
                    index = i;
                }
            }
            return index;
        }
    }
}
