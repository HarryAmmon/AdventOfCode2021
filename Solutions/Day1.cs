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
            throw new System.NotImplementedException();
        }
    }
}