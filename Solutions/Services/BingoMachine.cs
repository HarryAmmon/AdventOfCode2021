using System;
using System.Collections.Generic;
using Solutions.Models;

namespace Solutions.Services
{
    public class BingoMachine
    {
        private readonly List<int> _numbers;
        private readonly List<BingoCard> _cards;
        private readonly List<BingoCard> _winningCards;
        public BingoMachine(IEnumerable<int> numbers, IEnumerable<BingoCard> cards)
        {
            _cards = new List<BingoCard>(cards);
            _numbers = new List<int>(numbers);
            _winningCards = new List<BingoCard>();
        }

        public int CalculateFirstWinningTicketScore()
        {
            for (int i = 0; i < _numbers.Count; i++)
            {
                MarkCards(_numbers[i]);
                CheckForWinningCards(_numbers[i]);

                if (_winningCards.Count >= 1)
                {
                    return CalculateScore(_winningCards[0]);
                }
            }
            return -1;
        }

        public int CalculateLastWinningTicketScore()
        {
            for (int i = 0; i < _numbers.Count; i++)
            {
                MarkCards(_numbers[i]);
                CheckForWinningCards(_numbers[i]);
            }
            return CalculateScore(_winningCards[_winningCards.Count - 1]);
        }
        private int CalculateScore(BingoCard card)
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
            int winningScore = UnmarkedCardsTotal * card.WinningNumber;
            card.Score = winningScore;
            return winningScore;
        }

        public List<BingoCard> CheckForWinningCards(int currentNumber)
        {
            List<BingoCard> cardsToRemove = new List<BingoCard>();
            foreach (var card in _cards)
            {
                for (int i = 0; i < card.Count; i++)
                {
                    if (CheckColumn(card, i) || CheckRow(card, i))
                    {
                        card.WinningNumber = currentNumber;
                        _winningCards.Add(card);
                        cardsToRemove.Add(card);
                    }
                }
            }
            foreach (var card in cardsToRemove)
            {
                _cards.Remove(card);
            }
            return _winningCards;
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