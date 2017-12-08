using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode2017.Days
{
    public class DaySeven
    {
        private static List<RootObject> list = new List<RootObject>();
        public static string PartOne(string input)
        {
            var lines = input.Split("\r\n");
            list.Clear();

            foreach (var line in lines)
            {
                list.Add(LineToRootObject(line));
            }

            var first = GetFirst(list);

            return first.Name;
        }

        public static int PartTwo(string input)
        {
            var lines = input.Split("\r\n");
            list.Clear();

            foreach (var line in lines)
            {
                list.Add(LineToRootObject(line));
            }

            var first = GetFirst(list);
            var fullList = new List<RootObjectFull>();
            fullList.Add(Populate(first));

            var counts = new List<int>();
            var result = AssertWeight(fullList.First());

            return result;
        }

        private static int AssertWeight(RootObjectFull root)
        {
            var counts = new List<int>();
            foreach (var sub in root.SubPrograms)
            {
                counts.Add(CountWeight(sub));
            }

            try
            {
                var key = counts.GroupBy(r => r).Where(r => r.Count() == 1).First().Key;
                var result = AssertWeight(root.SubPrograms.First(r => CountWeight(r) == key));
                if (result == 0)
                {
                    var diff = counts.First(i => i != key) - key;

                    return key += diff;
                }
                else
                {
                    return result;
                }
            }
            catch
            {
                return 0;
            }
        }      

        private static int CountWeight(RootObjectFull root)
        {
            var result = 0;
            result += root.Weight;
            if (root.SubPrograms != null)
            {
                foreach (var sub in root.SubPrograms)
                {
                    //result += sub.Weight;
                    result += CountWeight(sub);
                }
            }
            return result;
        }

        private static RootObjectFull Populate(RootObject root)
        {
            var full = new RootObjectFull();
            full.Name = root.Name;
            full.Weight = root.Weight;
            full.SubPrograms = new List<RootObjectFull>();

            if (root.SubPrograms != null)
            {
                foreach (var sub in root.SubPrograms)
                {
                    var entry = list.First(r => r.Name.Equals(sub));
                    full.SubPrograms.Add(Populate(entry));
                }
            }

            return full;
        }

        private static RootObject GetFirst(List<RootObject> list)
        {
            foreach (var root in list)
            {
                var found = false;
                foreach (var root2 in list)
                {
                    if (root2.SubPrograms == null)
                    {
                        continue;
                    }

                    foreach (var sub in root2.SubPrograms)
                    {
                        if (sub.Equals(root.Name))
                        {
                            found = true;
                            break;
                        }
                    }

                    if (found)
                    {
                        break;
                    }
                }

                if (!found)
                {
                    return root;
                }
            }

            return null;
        }

        private static RootObject LineToRootObject(string line)
        {
            var root = new RootObject();
            var split = line.Split(' ');

            root.Name = split[0];
            int.TryParse(split[1].Replace("(", "").Replace(")", ""), out int weight);
            root.Weight = weight;

            if (split.Length > 2)
            {
                var subPrograms = new List<string>();
                for (int i = 3; i < split.Length; i++)
                {
                    subPrograms.Add(split[i].Replace(",", ""));
                }
                root.SubPrograms = subPrograms;
            }

            return root;
        }
    }

    class RootObject
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public List<string> SubPrograms { get; set; }
    }

    class RootObjectFull
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public List<RootObjectFull> SubPrograms { get; set; }
    }
}
