using System.Collections.Generic;
using AdventOfCodeCore;

namespace Solutions
{
    public class Day1 : ISolution<int>
    {
        public int Part1(string[] fileContent)
        {
            List<int> depths = new List<int>();
            foreach (var depth in fileContent)
            {
                depths.Add(int.Parse(depth));
            }
            return Comparator(depths);
        }

        public int Part2(string[] fileContent)
        {
            List<int> windows = new List<int>();
            for (int i = 0; i < fileContent.Length - 2; i++)
            {
                windows.Add(int.Parse(fileContent[i]) + int.Parse(fileContent[i + 1]) + int.Parse(fileContent[i + 2]));
            }
            return Comparator(windows);
        }

        private int Comparator(List<int> items)
        {
            int count = 0;
            for (int i = 1; i < items.Count; i++)
            {
                if (items[i] > items[i - 1])
                {
                    count++;
                }
            }
            return count;
        }
    }
}