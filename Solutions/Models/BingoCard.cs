using System.Collections.Generic;

namespace Solutions.Models
{
    public class BingoCard : List<List<BingoSquare>>
    {
        public int Score { get; set; }
        public int WinningNumber { get; set; }
        public BingoCard()
        {
            for (int i = 0; i < 5; i++)
            {
                this.Add(new List<BingoSquare>());
            }
        }
    }
}