using System.Collections.Generic;
using AdventOfCodeCore;

namespace Solutions
{
    public class Day1 : ISolution<int>
    {
        public int Part1(string[] fileContent)
        {
            int count = 0;
            for (int i = 1; i < fileContent.Length; i++)
            {
                if (int.Parse(fileContent[i]) > int.Parse(fileContent[i - 1]))
                {
                    count++;
                }
            }
            return count;
        }

        public int Part2(string[] fileContent)
        {
            int count = 0;
            List<int> windows = new List<int>();
            for (int i = 0; i < fileContent.Length - 2; i++)
            {
                windows.Add(int.Parse(fileContent[i]) + int.Parse(fileContent[i + 1]) + int.Parse(fileContent[i + 2]));
            }
            for (int i = 1; i < windows.Count; i++)
            {
                if (windows[i] > windows[i - 1])
                {
                    count++;
                }
            }
            return count;
        }
    }
}