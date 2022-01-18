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
            var numbers = factory.GenerateNumbers(fileContent[0]);
            var machine = new BingoMachine(numbers, cards);

            return machine.CalculateFirstWinningTicketScore();
        }

        public int Part2(string[] fileContent)
        {
            var factory = new BingoCardFactory();
            var cards = factory.GenerateBingoCards(fileContent);
            var numbers = factory.GenerateNumbers(fileContent[0]);
            var machine = new BingoMachine(numbers, cards);

            return machine.CalculateLastWinningTicketScore();
        }
    }
}