using System.Collections.Generic;
using Solutions.Models;

namespace Solutions.Services
{
    public class BingoCardFactory
    {
        public List<BingoCard> GenerateBingoCards(string[] fileContent)
        {
            List<BingoCard> bingoCards = new List<BingoCard>();
            // Start at line 2 as line 0 contains random numbers and line 1 is blank
            BingoCard card = new BingoCard();
            int cardRow = 0;
            for (int i = 2; i < fileContent.Length; i++)
            {
                if (string.IsNullOrEmpty(fileContent[i]))
                {
                    bingoCards.Add(card);
                    card = new BingoCard();
                    cardRow = 0;
                }
                else
                {
                    var lines = fileContent[i].Split(' ');
                    foreach (var line in lines)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            card[cardRow].Add(new BingoSquare(int.Parse(line)));
                        }
                    }
                    cardRow++;
                }
                if (i == fileContent.Length - 1)
                {
                    bingoCards.Add(card);
                }
            }
            return bingoCards;
        }
        public IEnumerable<int> GenerateNumbers(string numbers)
        {
            var intNumbers = new List<int>();
            var stringNumbers = numbers.Split(',');
            foreach (var number in stringNumbers)
            {
                intNumbers.Add(int.Parse(number));
            }
            return intNumbers;
        }
    }
}