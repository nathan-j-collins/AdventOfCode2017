using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2017.Days
{
    public class DayThree
    {
        public static int PartOne(int input)
        {
            int topleft = 5;
            int topright = 3;
            int bottomleft = 7;
            int bottomright = 9;
            int topleftaddition = 4;
            int toprightaddition = 2;
            int bottomleftaddition = 6;
            int bottomrightaddition = 8;
            int addition = 0;
            int counter = 0;
            while (topleft < input && topright < input && bottomleft < input && bottomright < input)
            {
                topleftaddition += 8;
                toprightaddition += 8;
                bottomleftaddition += 8;
                bottomrightaddition += 8;
                topleft += topleftaddition;
                topright += toprightaddition;
                bottomleft += bottomleftaddition;
                bottomright += bottomrightaddition;
                counter++;
            }

            var size = topleft - topright;
            var middle = size / 2;
            var difference = 0;
            if (topleft > input && topright < input)
            {
                difference = topleft - input;
            }
            else if (topleft < input && bottomleft > input)
            {
                difference = bottomleft - input;
            }
            else if (bottomleft < input && bottomright > input)
            {
                difference = bottomright - input;
            }
            else if (topright < input && bottomright > input)
            {
                difference = input - topright;
            }
            Console.WriteLine(difference);
            Console.WriteLine(middle);
            var distancetomiddle = 0;
            if (difference > middle)
            {
                distancetomiddle = difference - middle;
            }
            else
            {
                distancetomiddle = middle - difference;
            }
            Console.WriteLine(distancetomiddle);
            Console.WriteLine(size);
            return distancetomiddle + (size / 2);
        }

        public static int PartTwo(int input)
        {

            return 0;
        }
    }
}
