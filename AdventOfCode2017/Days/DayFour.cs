using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AdventOfCode2017.Days
{
    public class DayFour
    {
        public static int PartOne(string input)
        {
            var result = 0;
            var lines = input.Split("\r\n");
            foreach (var line in lines)
            {
                var words = line.Split(' ');
                var wordcount = words.Count();
                var countAfterRemoval = words.Distinct().Count();

                if (wordcount == countAfterRemoval)
                {
                    result ++;
                }
            }

            return result;
        }

        public static int PartTwo(string input)
        {
            var result = 0;

            var lines = input.Split("\r\n");
            foreach (var line in lines)
            {
                var isValid = true;
                var words = line.Split(' ');

                for (int i = 0; i < words.Length; i++)
                {
                    var firstWord = String.Concat(words[i].OrderBy(c => c));
                    for (int j = 0; j < words.Length; j++)
                    {
                        if (i == j)
                        {
                            continue;
                        }
                        var secondWord = String.Concat(words[j].OrderBy(c => c));
                        if (firstWord.Equals(secondWord))
                        {
                            isValid = false;
                        }
                    }
                }

                if (isValid)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
