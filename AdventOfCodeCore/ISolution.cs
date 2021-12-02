namespace AdventOfCodeCore
{
    public interface ISolution<T>
    {
        T Part1(string[] fileContent);
        T Part2(string[] fileContent);
    }
}