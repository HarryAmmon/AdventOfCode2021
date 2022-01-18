namespace Solutions.Models
{
    public class BingoSquare
    {
        public int Number { get; set; }
        public bool Marked { get; set; }
        public BingoSquare(int number)
        {
            Number = number;
            Marked = false;
        }
    }
}