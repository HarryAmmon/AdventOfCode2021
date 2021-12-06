using AdventOfCodeCore;
using Solutions.Services;

namespace Solutions
{
    public class Day4 : ISolution<int>
    {
        public int Part1(string[] fileContent)
        {
            var factory = new BingoCardFactory();
            var cards = factory.GenerateBingoCards(fileContent);
            return -1;
        }

        public int Part2(string[] fileContent)
        {
            throw new System.NotImplementedException();
        }
    }
}