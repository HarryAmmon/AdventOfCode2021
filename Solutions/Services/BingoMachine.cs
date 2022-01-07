using System;
using System.Collections.Generic;
using Solutions.Models;

namespace Solutions.Services
{
    public class BingoMachine
    {
        private readonly List<int> _numbers;
        private readonly IEnumerable<BingoCard> _cards;
        public BingoMachine(IEnumerable<int> numbers, IEnumerable<BingoCard> cards)
        {
            _cards = cards;
            _numbers = new List<int>(numbers);
        }

        public int CalculateFirstWinningTicketScore()
        {
            for (int i = 0; i < _numbers.Count; i++)
            {
                BingoCard winningCard;

                MarkCards(_numbers[i]);
                if (CheckCards(out winningCard))
                {
                    return CalculateScore(winningCard, _numbers[i]);
                }
            }

            return -1;
        }

        private int CalculateScore(BingoCard card, int winningNumber)
        {
            int UnmarkedCardsTotal = 0;
            foreach (var row in card)
            {
                foreach (var square in row)
                {
                    if (!square.Marked)
                    {
                        UnmarkedCardsTotal += square.Number;
                    }
                }
            }

            return UnmarkedCardsTotal * winningNumber;
        }

        public bool CheckCards(out BingoCard winningCard)
        {
            winningCard = null;
            foreach (var card in _cards)
            {
                for (int i = 0; i < card.Count; i++)
                {
                    if (CheckColumn(card, i) || CheckRow(card, i))
                    {
                        winningCard = card;
                        return true;
                    }
                }
            }
            return false;
        }

        public void MarkCards(int number)
        {
            foreach (var card in _cards)
            {
                foreach (var row in card)
                {
                    foreach (var square in row)
                    {
                        if (square.Number == number)
                        {
                            square.Marked = true;
                        }
                    }
                }
            }
        }

        public bool CheckColumn(BingoCard card, int column)
        {
            foreach (var row in card)
            {
                if (!row[column].Marked)
                {
                    return false;
                }
            }
            return true;
        }

        public bool CheckRow(BingoCard card, int row)
        {
            foreach (var bingoSquare in card[row])
            {
                if (!bingoSquare.Marked)
                {
                    return false;
                }
            }
            return true;
        }
    }
}