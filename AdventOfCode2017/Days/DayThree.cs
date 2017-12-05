using System;
using System.Collections.Generic;

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
        
        public static void Reset()
        {
            directions direction = directions.RIGHT;
            directionSteps = 0;
            directionAmount = 1;
            directionCounter = 0;
            dict = new Dictionary<int, Dictionary<int, int>>();
    }

        public static int PartTwo(int input)
        {
            return CreateDictionary(input);
        }

        private enum directions
        {
            UP,
            DOWN,
            LEFT,
            RIGHT
        };

        private static directions direction = directions.RIGHT;
        private static int directionSteps = 0;
        private static int directionAmount = 1;
        private static int directionCounter = 0;

        private static Dictionary<int, Dictionary<int, int>> dict = new Dictionary<int, Dictionary<int, int>>();

        private static int CreateDictionary(int input)
        {
            var xCo = 0;
            var yCo = 0;
            var val = 1;
            dict[xCo] = new Dictionary<int, int>();
            dict[xCo][yCo] = val;

            while (val <= input)
            {
                GetNewDirection();
                var newCo = GetNewCoOrdinates(xCo, yCo);
                xCo = newCo.x;
                yCo = newCo.y;
                val = GetNewValue(xCo, yCo);

                if (!dict.ContainsKey(xCo))
                {
                    dict[xCo] = new Dictionary<int, int>();
                }
                dict[xCo][yCo] = val;
            }

            return val;
        }

        private static void GetNewDirection()
        {
            var inc = false;
            if (directionCounter == (2 * directionAmount))
            {
                inc = true;
                directionCounter = 0;
            }

            if (directionSteps < directionAmount)
            {
                return;
            }

            switch (direction)
            {
                case directions.RIGHT:
                    direction = directions.UP; break;
                case directions.LEFT:
                    direction = directions.DOWN; break;
                case directions.UP:
                    direction = directions.LEFT; break;
                case directions.DOWN:
                    direction = directions.RIGHT; break;
                default:
                    direction = directions.UP; break;
            }
            directionSteps = 0;
            if (inc)
            {
                directionAmount++;
            }
        }

        private static (int x, int y) GetNewCoOrdinates(int oldx, int oldy)
        {
            (int x, int y) tup = (oldx, oldy);

            switch(direction)
            {
                case directions.RIGHT:
                    tup.x++; break;
                case directions.LEFT:
                    tup.x--; break;
                case directions.UP:
                    tup.y++; break;
                case directions.DOWN:
                    tup.y--; break;
                default:
                    return (0, 0);
            }
            directionSteps++;
            directionCounter++;
            return tup;
        }

        private static int GetNewValue(int x, int y)
        {
            var result = 0;
            var list = new List<int> { 1, -1, 0 };
            for (int i = 0; i < list.Count; i++)
            {
                var first = list[i];
                for (int j = 0; j < list.Count; j++)
                {
                    var second = list[j];
                    if (first == 0 && second == 0)
                    {
                        continue;
                    }

                    var newX = x + first;
                    var newY = y + second;

                    if (dict.ContainsKey(newX) && dict[newX].ContainsKey(newY))
                    {
                        result += dict[newX][newY];
                    }
                }
            }

            return result;
        }
        
    }
}
